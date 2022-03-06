using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CefSharpEvents
{
	public class Message
	{
		[JsonProperty("data")]
		public object Data { get; set; }
	}
}
