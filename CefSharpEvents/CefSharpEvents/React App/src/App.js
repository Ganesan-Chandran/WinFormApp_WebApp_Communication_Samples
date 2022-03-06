import './App.css';
import { useEffect, useState } from 'react';
import { SendMessageHandler } from "./EventHandler";

function App() {

  const [chatMessage, SetChatMessage] = useState("");
  const [chatHistory, SetChatHistory] = useState("");

  useEffect(() => {
    document.addEventListener("messageReceiveEvent", ReceiveMesaageHandler);
    return () => {
      document.removeEventListener("messageReceiveEvent", ReceiveMesaageHandler);
    };
  }, []);

  function messageChange(e) {
    SetChatMessage(e.target.value);
  }

  function ReceiveMesaageHandler(e) {
    SetChatHistory(prevChat => prevChat !== "" ? (prevChat + "\nWindows :" + e.detail.data) : ("Windows :" + e.detail.data));    
  }

  function Send() {
    SetChatHistory(prevChat => prevChat !== "" ? (prevChat + "\nWeb :" + chatMessage) : ("Web :" + chatMessage));    
    SendMessageHandler(chatMessage);
  }

  return (
    <div className="App">
      <div className="head">
        Web - Chat Application
      </div>
      <div className="container">
        <label>Message:</label>
        <br />
        <input type="text" id="message" onChange={messageChange} />
        <button className="btn-Send" onClick={Send}>Send</button>
        <br />
        <br />
        <label>Chat History:</label>
        <br />
        <textarea readOnly defaultValue={chatHistory} rows={10} cols={50}>
        </textarea>
        <br />
      </div>
    </div>
  );
}

export default App;
