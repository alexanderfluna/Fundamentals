#include "Bank.h"
#include "Customer.h"
#include "BankAccount.h"
#include "RijndaelEncryption.h"
#using "system.dll"
using namespace System;
using namespace System::IO;
using namespace System::Net;
using namespace System::Net::Sockets;
using namespace System::Security::Cryptography;
using namespace System::Text;

int main(array<String^>^ argv)
{
	// Makes connection to client
	int port = 9999;
	IPAddress^ ipAddress = (IPAddress^) Dns::GetHostEntry(Dns::GetHostName())->AddressList[0];
	IPEndPoint^ ipEndpoint = gcnew IPEndPoint(ipAddress, port);
	Socket^ listenerSocket = gcnew Socket(ipAddress->AddressFamily, SocketType::Stream, ProtocolType::Tcp);
	listenerSocket->Bind(ipEndpoint);
	listenerSocket->Listen(1);
	Console::WriteLine("Server listener blocking status is {0}",
	listenerSocket->Blocking);
	Socket^ serverSocket = listenerSocket->Accept();
	Console::WriteLine("New connection accepted");
	listenerSocket->Close();
	NetworkStream^ netStream = gcnew NetworkStream(serverSocket);
	BinaryReader^ br = gcnew BinaryReader(netStream);
	BinaryWriter^ bw = gcnew BinaryWriter(netStream);

	Bank^ theBank = gcnew Bank();
	Customer^ currentCustomer;
	BankAccount^ currentAccount;
	RijndaelEncryption re;

	try
	{
		int value1 = 0;
		double value2 = 0.0;
		
		value1 = br->ReadInt32();
		value2 = br->ReadInt32();
		currentCustomer = theBank->FindCustomer(value1, value2);
		Console::WriteLine("The customer's number is: {0}. The customer's pin is: {1}.", value1, value2);
		

		while (true) // until client ends the input
		{
			
			value1 = br->ReadByte();
			value2 = br->ReadDouble();

			switch (value1) {
			case 11: // Checking Withdraw <number>
				Console::WriteLine("Withdraw <{0}>: ${1} was withdrawn from the customer's checking account. ", value2, value2);
				currentAccount = currentCustomer->GetCheckingAccnt();
				currentAccount->Withdraw(value2);
				bw->Write(currentAccount->GetBalance());
				Console::WriteLine("Balance: $" + currentAccount->GetBalance());
				break;
			case 12: // Checking Deposit <number>
				Console::WriteLine("Deposit <{0}>: ${1} was deposited into the customer's checking account. ", value2, value2);
				currentAccount = currentCustomer->GetCheckingAccnt();
				currentAccount->Deposit(value2);
				bw->Write(currentAccount->GetBalance());
				Console::WriteLine("Balance: $" + currentAccount->GetBalance());
				break;
			case 21: // Savings Withdrawal <number>
				Console::WriteLine("Withdraw <{0}>: ${1} was withdrawn from the customer's savings account. ", value2, value2);
				currentAccount = currentCustomer->GetSavingsAccnt();
				currentAccount->Withdraw(value2);
				bw->Write(currentAccount->GetBalance());
				Console::WriteLine("Balance: $" + currentAccount->GetBalance());
				break;
			case 22: // Savings Deposit <number>
				Console::WriteLine("Deposit <{0}>: ${1} was deposited into the customer's savings account. ", value2, value2);
				currentAccount = currentCustomer->GetSavingsAccnt();
				currentAccount->Deposit(value2);
				bw->Write(currentAccount->GetBalance());
				Console::WriteLine("Balance: $" + currentAccount->GetBalance());
				break;
			}
		}
	} 
	catch (EndOfStreamException^ e)
	{
		Console::WriteLine("QUIT: End of client data.");
	}
	catch (IOException^ e)
	{
		Console::WriteLine("IOException {0}", e);
	}

	serverSocket->Shutdown(SocketShutdown::Both);
	serverSocket->Close();
	netStream->Close();
}