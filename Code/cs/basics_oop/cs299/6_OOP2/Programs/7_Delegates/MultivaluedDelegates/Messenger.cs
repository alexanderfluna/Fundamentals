// Messenger.cs - Adding and removing delegates. 


using System;


namespace ConsoleApplication1
{
	public delegate void Message(string txt);

	public class Messenger
	{
  
		private string sender;
		private Message message; // a delegate istance

		public Messenger(string sender)
		{
			this.sender = sender;
			message = null;
		}

		public Messenger(string sender, Message aMessage)
		{
			this.sender = sender;
			message = aMessage;
		}

		public void InstallMessage(Message mes)
		{
			this.message += mes;
		}   

		public void UnInstallMessage(Message mes)
		{
			this.message -= mes;
		}   

		public void DoSend()
		{
			// will call all methods of delegate message
			// syncronously and in order
			message("Message from " + sender);
		}
	}

}
