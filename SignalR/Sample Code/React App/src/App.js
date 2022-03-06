import './App.css';
import { useEffect, useState } from 'react';

function App() {

  const [chatHubProxy, SetChatHubProxy] = useState("");
  const [connection, SetConnection] = useState(null);
  const [chatMessage, SetChatMessage] = useState("");  
  const [chatHistory, SetChatHistory] = useState("");

  function Send() {
    chatHubProxy.invoke('SendToWinForm', "Web", chatMessage).done(function () {
      SetChatHistory(prevChat => prevChat !== "" ? (prevChat + "\nWeb :" + chatMessage) : ("\nWeb :" + chatMessage));
    }).fail(function (error) {
      console.log('Invocation failed. Error: ' + error);
    });
  }

  function Connect() {
    try {
      let localConnection = window.$.hubConnection("http://localhost:57142");
      localConnection.qs = { 'version': '1.0' };
      var hubProxy = localConnection.createHubProxy('chathub');

      hubProxy.on('SendMessageToWebApp', function (eventName, data) {
        SetChatHistory(prevChat => prevChat !== "" ? (prevChat + "\n" + eventName + ":" + data) : (eventName + ":" + data));
      });

      localConnection.start()
        .done(function () { alert("Connected Successfully"); console.log('Now connected, connection ID=' + localConnection.id); })
        .fail(function () { console.log('Could not connect'); });

      SetChatHubProxy(hubProxy);
      SetConnection(localConnection);
    } catch (error) {
      console.log(error);
    }
  }

  function messageChange(e) {
    SetChatMessage(e.target.value);
  }

  useEffect(() => {
    return (()=> {
      connection.close();
    })
  // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [])

  return (
    <div className="App">
      <div className="container">
        <button onClick={Connect}>Connect</button>
        <br />
        <br />
        <label>Message:</label>
        <br />
        <input type="text" id="message" onChange={messageChange} />
        <button className="btn-Send" onClick={Send}>Send</button>
        <br />
        <br />
        <label>Chat History:</label>
        <br />
        <textarea defaultValue={chatHistory} rows={10} cols={50}>
        </textarea>
        <br />
      </div>
    </div>
  );
}

export default App;
