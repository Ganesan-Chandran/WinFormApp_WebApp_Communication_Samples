
export function SendMessageHandler(e) {
  const event = new CustomEvent("messageSentEvent", {
    detail: {
      data: e,
      type: "SendMessage"
    }
  });
  document.dispatchEvent(event);
}
