// Form1.h
// Contains the event handlers for the form

#pragma once
#include "ATM.h";
#include "Customer.h"
#include "Bank.h"
#include "RijndaelEncryption.h"

namespace CppGUIPROJECT {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Net;
	using namespace System::Net::Sockets;
	using namespace System::Threading;
	using namespace System::Text;
	using namespace System::Security::Cryptography;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
		}
		Bank bank;
		ATM atm;
		RijndaelEncryption re;
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private:
		double checkingBalance = -1;
		double savingsBalance = -1;
		// application data members
		int port;
		int messageCount;
		IPAddress^ ipAddress;
		IPEndPoint^ ipEndpoint;
		Socket^ clientSocket;
		NetworkStream^ netStream;
		BinaryReader^ br;
		BinaryWriter^ bw;
	private: System::Windows::Forms::TextBox^ txtNumber;
	private: System::Windows::Forms::Button^ btn1;
	private: System::Windows::Forms::Button^ btn2;
	private: System::Windows::Forms::Button^ btn3;
	private: System::Windows::Forms::Button^ btn4;
	private: System::Windows::Forms::Button^ btn5;
	private: System::Windows::Forms::Button^ btn6;
	private: System::Windows::Forms::Button^ btn7;
	private: System::Windows::Forms::Button^ btn8;
	private: System::Windows::Forms::Button^ btn9;
	private: System::Windows::Forms::Label^ lblDisplay;
	private: System::Windows::Forms::Button^ btnA;
	private: System::Windows::Forms::Button^ btnB;
	private: System::Windows::Forms::Button^ btnC;
	protected:

	protected:

	private: System::Windows::Forms::Button^ btn0;
	private: System::Windows::Forms::Button^ btnDot;
	private: System::Windows::Forms::Button^ btnCE;
	private: System::Windows::Forms::Label^ lblState;
	private: System::Windows::Forms::Label^ lblCustomerNumber;
	private: System::Windows::Forms::Label^ lblCustomerPIN;
	private: System::Windows::Forms::Label^ lblAccountType;
	private: System::Windows::Forms::Label^ lblTransaction;
	private: System::Windows::Forms::Label^ lblTransactionAmount;
	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->txtNumber = (gcnew System::Windows::Forms::TextBox());
			this->btn1 = (gcnew System::Windows::Forms::Button());
			this->btn2 = (gcnew System::Windows::Forms::Button());
			this->btn3 = (gcnew System::Windows::Forms::Button());
			this->btn4 = (gcnew System::Windows::Forms::Button());
			this->btn5 = (gcnew System::Windows::Forms::Button());
			this->btn6 = (gcnew System::Windows::Forms::Button());
			this->btn7 = (gcnew System::Windows::Forms::Button());
			this->btn8 = (gcnew System::Windows::Forms::Button());
			this->btn9 = (gcnew System::Windows::Forms::Button());
			this->lblDisplay = (gcnew System::Windows::Forms::Label());
			this->btnA = (gcnew System::Windows::Forms::Button());
			this->btnB = (gcnew System::Windows::Forms::Button());
			this->btnC = (gcnew System::Windows::Forms::Button());
			this->btn0 = (gcnew System::Windows::Forms::Button());
			this->btnDot = (gcnew System::Windows::Forms::Button());
			this->btnCE = (gcnew System::Windows::Forms::Button());
			this->lblState = (gcnew System::Windows::Forms::Label());
			this->lblCustomerNumber = (gcnew System::Windows::Forms::Label());
			this->lblCustomerPIN = (gcnew System::Windows::Forms::Label());
			this->lblAccountType = (gcnew System::Windows::Forms::Label());
			this->lblTransaction = (gcnew System::Windows::Forms::Label());
			this->lblTransactionAmount = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// txtNumber
			// 
			this->txtNumber->Location = System::Drawing::Point(77, 25);
			this->txtNumber->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->txtNumber->Name = L"txtNumber";
			this->txtNumber->Size = System::Drawing::Size(173, 22);
			this->txtNumber->TabIndex = 0;
			// 
			// btn1
			// 
			this->btn1->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn1->ForeColor = System::Drawing::SystemColors::ControlText;
			this->btn1->Location = System::Drawing::Point(77, 53);
			this->btn1->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn1->Name = L"btn1";
			this->btn1->Size = System::Drawing::Size(61, 36);
			this->btn1->TabIndex = 1;
			this->btn1->Text = L"1";
			this->btn1->UseVisualStyleBackColor = false;
			this->btn1->Click += gcnew System::EventHandler(this, &Form1::btn1_Click);
			// 
			// btn2
			// 
			this->btn2->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn2->Location = System::Drawing::Point(136, 53);
			this->btn2->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn2->Name = L"btn2";
			this->btn2->Size = System::Drawing::Size(61, 36);
			this->btn2->TabIndex = 2;
			this->btn2->Text = L"2";
			this->btn2->UseVisualStyleBackColor = false;
			this->btn2->Click += gcnew System::EventHandler(this, &Form1::btn2_Click);
			// 
			// btn3
			// 
			this->btn3->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn3->Location = System::Drawing::Point(189, 53);
			this->btn3->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn3->Name = L"btn3";
			this->btn3->Size = System::Drawing::Size(61, 36);
			this->btn3->TabIndex = 3;
			this->btn3->Text = L"3";
			this->btn3->UseVisualStyleBackColor = false;
			this->btn3->Click += gcnew System::EventHandler(this, &Form1::btn3_Click);
			// 
			// btn4
			// 
			this->btn4->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn4->Location = System::Drawing::Point(77, 86);
			this->btn4->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn4->Name = L"btn4";
			this->btn4->Size = System::Drawing::Size(61, 34);
			this->btn4->TabIndex = 4;
			this->btn4->Text = L"4";
			this->btn4->UseVisualStyleBackColor = false;
			this->btn4->Click += gcnew System::EventHandler(this, &Form1::btn4_Click);
			// 
			// btn5
			// 
			this->btn5->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn5->Location = System::Drawing::Point(136, 86);
			this->btn5->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn5->Name = L"btn5";
			this->btn5->Size = System::Drawing::Size(61, 34);
			this->btn5->TabIndex = 5;
			this->btn5->Text = L"5";
			this->btn5->UseVisualStyleBackColor = false;
			this->btn5->Click += gcnew System::EventHandler(this, &Form1::btn5_Click);
			// 
			// btn6
			// 
			this->btn6->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn6->Location = System::Drawing::Point(189, 86);
			this->btn6->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn6->Name = L"btn6";
			this->btn6->Size = System::Drawing::Size(61, 34);
			this->btn6->TabIndex = 6;
			this->btn6->Text = L"6";
			this->btn6->UseVisualStyleBackColor = false;
			this->btn6->Click += gcnew System::EventHandler(this, &Form1::btn6_Click);
			// 
			// btn7
			// 
			this->btn7->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn7->Location = System::Drawing::Point(77, 118);
			this->btn7->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn7->Name = L"btn7";
			this->btn7->Size = System::Drawing::Size(61, 34);
			this->btn7->TabIndex = 7;
			this->btn7->Text = L"7";
			this->btn7->UseVisualStyleBackColor = false;
			this->btn7->Click += gcnew System::EventHandler(this, &Form1::btn7_Click);
			// 
			// btn8
			// 
			this->btn8->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn8->Location = System::Drawing::Point(136, 118);
			this->btn8->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn8->Name = L"btn8";
			this->btn8->Size = System::Drawing::Size(61, 34);
			this->btn8->TabIndex = 8;
			this->btn8->Text = L"8";
			this->btn8->UseVisualStyleBackColor = false;
			this->btn8->Click += gcnew System::EventHandler(this, &Form1::btn8_Click);
			// 
			// btn9
			// 
			this->btn9->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn9->Location = System::Drawing::Point(189, 118);
			this->btn9->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn9->Name = L"btn9";
			this->btn9->Size = System::Drawing::Size(61, 34);
			this->btn9->TabIndex = 9;
			this->btn9->Text = L"9";
			this->btn9->UseVisualStyleBackColor = false;
			this->btn9->Click += gcnew System::EventHandler(this, &Form1::btn9_Click);
			// 
			// lblDisplay
			// 
			this->lblDisplay->AutoSize = true;
			this->lblDisplay->BackColor = System::Drawing::Color::White;
			this->lblDisplay->Location = System::Drawing::Point(37, 185);
			this->lblDisplay->MaximumSize = System::Drawing::Size(255, 77);
			this->lblDisplay->MinimumSize = System::Drawing::Size(255, 77);
			this->lblDisplay->Name = L"lblDisplay";
			this->lblDisplay->Size = System::Drawing::Size(255, 77);
			this->lblDisplay->TabIndex = 10;
			this->lblDisplay->Text = L"Enter customer number and press OK.";
			// 
			// btnA
			// 
			this->btnA->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btnA->Location = System::Drawing::Point(116, 264);
			this->btnA->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btnA->Name = L"btnA";
			this->btnA->Size = System::Drawing::Size(89, 39);
			this->btnA->TabIndex = 11;
			this->btnA->Text = L"OK";
			this->btnA->UseVisualStyleBackColor = false;
			this->btnA->Click += gcnew System::EventHandler(this, &Form1::btnA_Click);
			// 
			// btnB
			// 
			this->btnB->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btnB->Enabled = false;
			this->btnB->Location = System::Drawing::Point(116, 297);
			this->btnB->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btnB->Name = L"btnB";
			this->btnB->Size = System::Drawing::Size(89, 39);
			this->btnB->TabIndex = 12;
			this->btnB->UseVisualStyleBackColor = false;
			this->btnB->Click += gcnew System::EventHandler(this, &Form1::btnB_Click);
			// 
			// btnC
			// 
			this->btnC->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btnC->Location = System::Drawing::Point(116, 329);
			this->btnC->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btnC->Name = L"btnC";
			this->btnC->Size = System::Drawing::Size(89, 39);
			this->btnC->TabIndex = 13;
			this->btnC->Text = L"Exit";
			this->btnC->UseVisualStyleBackColor = false;
			this->btnC->Click += gcnew System::EventHandler(this, &Form1::btnC_Click);
			// 
			// btn0
			// 
			this->btn0->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btn0->Location = System::Drawing::Point(77, 148);
			this->btn0->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btn0->Name = L"btn0";
			this->btn0->Size = System::Drawing::Size(61, 34);
			this->btn0->TabIndex = 14;
			this->btn0->Text = L"0";
			this->btn0->UseVisualStyleBackColor = false;
			this->btn0->Click += gcnew System::EventHandler(this, &Form1::btn0_Click);
			// 
			// btnDot
			// 
			this->btnDot->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btnDot->Location = System::Drawing::Point(136, 148);
			this->btnDot->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btnDot->Name = L"btnDot";
			this->btnDot->Size = System::Drawing::Size(61, 34);
			this->btnDot->TabIndex = 15;
			this->btnDot->Text = L".";
			this->btnDot->UseVisualStyleBackColor = false;
			this->btnDot->Click += gcnew System::EventHandler(this, &Form1::btnDot_Click);
			// 
			// btnCE
			// 
			this->btnCE->BackColor = System::Drawing::SystemColors::GradientInactiveCaption;
			this->btnCE->Location = System::Drawing::Point(189, 148);
			this->btnCE->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->btnCE->Name = L"btnCE";
			this->btnCE->Size = System::Drawing::Size(61, 34);
			this->btnCE->TabIndex = 16;
			this->btnCE->Text = L"CE";
			this->btnCE->UseVisualStyleBackColor = false;
			this->btnCE->Click += gcnew System::EventHandler(this, &Form1::btnCE_Click);
			// 
			// lblState
			// 
			this->lblState->AutoSize = true;
			this->lblState->Location = System::Drawing::Point(113, 403);
			this->lblState->Name = L"lblState";
			this->lblState->Size = System::Drawing::Size(93, 17);
			this->lblState->TabIndex = 17;
			this->lblState->Text = L"state: START";
			// 
			// lblCustomerNumber
			// 
			this->lblCustomerNumber->AutoSize = true;
			this->lblCustomerNumber->Location = System::Drawing::Point(37, 429);
			this->lblCustomerNumber->Name = L"lblCustomerNumber";
			this->lblCustomerNumber->Size = System::Drawing::Size(124, 17);
			this->lblCustomerNumber->TabIndex = 18;
			this->lblCustomerNumber->Text = L"customerNumber: ";
			// 
			// lblCustomerPIN
			// 
			this->lblCustomerPIN->AutoSize = true;
			this->lblCustomerPIN->Location = System::Drawing::Point(69, 459);
			this->lblCustomerPIN->Name = L"lblCustomerPIN";
			this->lblCustomerPIN->Size = System::Drawing::Size(96, 17);
			this->lblCustomerPIN->TabIndex = 19;
			this->lblCustomerPIN->Text = L"customerPIN: ";
			// 
			// lblAccountType
			// 
			this->lblAccountType->AutoSize = true;
			this->lblAccountType->Location = System::Drawing::Point(67, 488);
			this->lblAccountType->Name = L"lblAccountType";
			this->lblAccountType->Size = System::Drawing::Size(98, 17);
			this->lblAccountType->TabIndex = 20;
			this->lblAccountType->Text = L"accountType: ";
			// 
			// lblTransaction
			// 
			this->lblTransaction->AutoSize = true;
			this->lblTransaction->Location = System::Drawing::Point(79, 520);
			this->lblTransaction->Name = L"lblTransaction";
			this->lblTransaction->Size = System::Drawing::Size(86, 17);
			this->lblTransaction->TabIndex = 21;
			this->lblTransaction->Text = L"transaction: ";
			// 
			// lblTransactionAmount
			// 
			this->lblTransactionAmount->AutoSize = true;
			this->lblTransactionAmount->Location = System::Drawing::Point(31, 549);
			this->lblTransactionAmount->Name = L"lblTransactionAmount";
			this->lblTransactionAmount->Size = System::Drawing::Size(134, 17);
			this->lblTransactionAmount->TabIndex = 22;
			this->lblTransactionAmount->Text = L"transactionAmount: ";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(326, 575);
			this->Controls->Add(this->lblTransactionAmount);
			this->Controls->Add(this->lblTransaction);
			this->Controls->Add(this->lblAccountType);
			this->Controls->Add(this->lblCustomerPIN);
			this->Controls->Add(this->lblCustomerNumber);
			this->Controls->Add(this->lblState);
			this->Controls->Add(this->btnCE);
			this->Controls->Add(this->btnDot);
			this->Controls->Add(this->btn0);
			this->Controls->Add(this->btnC);
			this->Controls->Add(this->btnB);
			this->Controls->Add(this->btnA);
			this->Controls->Add(this->lblDisplay);
			this->Controls->Add(this->btn9);
			this->Controls->Add(this->btn8);
			this->Controls->Add(this->btn7);
			this->Controls->Add(this->btn6);
			this->Controls->Add(this->btn5);
			this->Controls->Add(this->btn4);
			this->Controls->Add(this->btn3);
			this->Controls->Add(this->btn2);
			this->Controls->Add(this->btn1);
			this->Controls->Add(this->txtNumber);
			this->Margin = System::Windows::Forms::Padding(3, 2, 3, 2);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->ResumeLayout(false);
			this->PerformLayout();

			// Tries to make connection to server
			try {
				port = 9999;
				messageCount = 10;
				ipAddress = Dns::GetHostEntry(Dns::GetHostName())->AddressList[0];
				ipEndpoint = gcnew IPEndPoint(ipAddress, port);
				clientSocket = gcnew Socket(ipAddress->AddressFamily, SocketType::Stream, ProtocolType::Tcp);
				clientSocket->Connect(ipEndpoint);
				netStream = gcnew NetworkStream(clientSocket);
				br = gcnew BinaryReader(netStream);
				bw = gcnew BinaryWriter(netStream);
			}
			catch (SocketException^ e) {
				Console::WriteLine("The connection with the server was not made.");
				Environment::Exit(1);
			}
		}

#pragma endregion
private: System::Void btnA_Click(System::Object^ sender, System::EventArgs^ e) {
	switch (atm.GetState()) {

	case ATM::State::START:
		// Sets customerNumber variable to entered customer number and changes state to pin
		atm.SetCustomerNumber(Convert::ToInt32(txtNumber->Text));

		// Changes to layout for switching to the PIN state
		lblDisplay->Text = "Enter PIN and press OK";
		btnC->Text = "Cancel";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text += Convert::ToString(atm.customerNumber);

	case ATM::State::PIN:
		// Checks if valid pin
		if (bank.FindCustomer(atm.customerNumber, Convert::ToInt32(txtNumber->Text)) != nullptr) {

			// The state variable will change to ACCOUNT
			atm.SelectCustomer(Convert::ToInt32(txtNumber->Text));

			// Encrypts and sends customerNumber and pin to client
			array<Byte>^ encryptedMessage = re.Encrypt(Convert::ToString(atm.customerNumber), re.KEY, re.IV);
			bw->Write(encryptedMessage);
			encryptedMessage = re.Encrypt(txtNumber->Text, re.KEY, re.IV);
			bw->Write(encryptedMessage);

			// Changes to layout for switching to the ACCOUNT state
			lblDisplay->Text = "Select Account";
			btnA->Text = "Checking";
			btnB->Enabled = true;
			btnB->Text = "Savings";
			btnC->Enabled = true;
			btnC->Text = "Cancel";
			lblState->Text = "state: " + Convert::ToString(atm.GetState());
			lblCustomerPIN->Text += txtNumber->Text;
			txtNumber->Text = "";
		}
		// If not, ask again for pin
		else {
			txtNumber->Text = "";
		}
		break;

	case ATM::State::ACCOUNT:
		// Clicking "Checking" will set accordingly the variable accountType
		atm.SelectAccount(ATM::Account::CHECKING);

		if (checkingBalance < 0)
			checkingBalance = atm.GetBalance();

		// Changes to layout for switching to the TRANSACT state
		txtNumber->Text = "";
		lblDisplay->Text = "Balance = " + checkingBalance + "\n Enter amount and select transaction";
		btnA->Text = "Withdraw";
		btnB->Text = "Deposit";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblAccountType->Text = "accountType: " + Convert::ToString(atm.accountType);
		lblTransaction->Text = "transaction: ";
		lblTransactionAmount->Text = "transactionAmount: ";
		break;

	case ATM::State::TRANSACT:
		// Set the value of the variable transactionAmount to whatever the user withdrew
		atm.transactionAmount = Convert::ToDouble(txtNumber->Text);

		// Set variable transaction to WITHDRAWAL 
		atm.transaction = ATM::Transaction::WITHDRAWAL;

		if (atm.accountType == ATM::Account::CHECKING) {
			bw->Write(11); // Code 11: CHECKING WITHDRAWAL <number>
			bw->Write(atm.transactionAmount);
			checkingBalance = br->ReadDouble();
		}
		else if (atm.accountType == ATM::Account::SAVINGS) {
			bw->Write(21); // Code 21: SAVINGS WITHDRAWAL <number>
			bw->Write(atm.transactionAmount);
			savingsBalance = br->ReadDouble();
		}

		// State will transition to ACCOUNT
		atm.back();

		// Changes to layout for switching back to the ACCOUNT state
		txtNumber->Text = "";
		lblDisplay->Text = "Select Account";
		btnA->Text = "Checking";
		btnB->Text = "Savings";
		btnC->Text = "Cancel";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text = "customerNumber: " + Convert::ToString(atm.customerNumber);
		lblAccountType->Text = "accountType: ";
		lblTransaction->Text = "transaction: " + Convert::ToString(atm.transaction);
		lblTransactionAmount->Text = "transactionAmount: " + Convert::ToString(atm.transactionAmount);
		break;
	}
}



private: System::Void btnB_Click(System::Object^ sender, System::EventArgs^ e) {
	switch (atm.GetState()) {
	case ATM::State::START:
		break;

	case ATM::State::PIN:
		break;

	case ATM::State::ACCOUNT:

		// Clicking "Savings" will set accordingly the variable accountType
		atm.SelectAccount(ATM::Account::SAVINGS);

		if (savingsBalance < 0)
			savingsBalance = atm.GetBalance();

		// Changes to layout for switching to the TRANSACT state
		txtNumber->Text = "";
		lblDisplay->Text = "Balance = " + savingsBalance + "\n Enter amount and select transaction";
		btnA->Text = "Withdraw";
		btnB->Text = "Deposit";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblAccountType->Text = "accountType: " + Convert::ToString(atm.accountType);
		lblTransaction->Text = "transaction: ";
		lblTransactionAmount->Text = "transactionAmount: ";
		break;

	case ATM::State::TRANSACT:
		// Set the value of the variable transactionAmount to whatever the user deposited
		atm.transactionAmount = Convert::ToDouble(txtNumber->Text);

		// Set variable transaction to DEPOSIT
		atm.transaction = ATM::Transaction::DEPOSIT;

		if (atm.accountType == ATM::Account::CHECKING) {
			bw->Write(12); // Code 12: CHECKING DEPOSIT <number>
			bw->Write(atm.transactionAmount);
			checkingBalance = br->ReadDouble();
		}
		else if (atm.accountType == ATM::Account::SAVINGS) {
			bw->Write(22); // Code 22: SAVINGS DEPOSIT <number>
			bw->Write(atm.transactionAmount);
			savingsBalance = br->ReadDouble();
		}

		// State will transition back to ACCOUNT
		atm.back();

		// Changes to layout for switching back to the ACCOUNT state
		txtNumber->Text = "";
		lblDisplay->Text = "Select Account";
		btnA->Text = "Checking";
		btnB->Text = "Savings";
		btnC->Text = "Cancel";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text = "customerNumber: " + Convert::ToString(atm.customerNumber);
		lblAccountType->Text = "accountType: ";
		lblTransaction->Text = "transaction: " + Convert::ToString(atm.transaction);
		lblTransactionAmount->Text = "transactionAmount: " + Convert::ToString(atm.transactionAmount);
		break;
	}
}



private: System::Void btnC_Click(System::Object^ sender, System::EventArgs^ e) {
	switch (atm.GetState()) {

	case ATM::State::START:
		// If user clicks Exit, program will terminate
		atm.CloseAll();
		break;

	case ATM::State::PIN:
		atm.back();

		// Changes to layout for switching back to the START state
		txtNumber->Text = "";
		lblDisplay->Text = "Enter customer number and press OK.";
		btnA->Text = "OK";
		btnB->Enabled = false;
		btnB->Text = " ";
		btnC->Enabled = true;
		btnC->Text = "Exit";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text = "customerNumber: ";
		lblCustomerPIN->Text = "customerPIN: ";
		lblAccountType->Text = "accountType: ";
		lblTransaction->Text = "transaction: ";
		lblTransactionAmount->Text = "transactionAmount: ";
		break;

	case ATM::State::ACCOUNT:
		// Clicking "Cancel" will bring state back to START
		clientSocket->Close();
		netStream->Close();
		atm.Reset();

		// Changes to layout for switching back to the START state
		txtNumber->Text = "";
		lblDisplay->Text = "Enter customer number and press OK.";
		btnA->Text = "OK";
		btnB->Enabled = false;
		btnB->Text = " ";
		btnC->Enabled = true;
		btnC->Text = "Exit";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text = "customerNumber: ";
		lblCustomerPIN->Text = "customerPIN: ";
		lblAccountType->Text = "accountType: ";
		lblTransaction->Text = "transaction: ";
		lblTransactionAmount->Text = "transactionAmount: ";
		break;

	case ATM::State::TRANSACT:
		// Clicking "Cancel" will bring state back to ACCOUNT
		atm.back();

		// Changes to layout for switching back to the ACCOUNT state
		txtNumber->Text = "";
		lblDisplay->Text = "Select Account";
		btnA->Text = "Checking";
		btnB->Text = "Savings";
		btnC->Text = "Cancel";
		lblState->Text = "state: " + Convert::ToString(atm.GetState());
		lblCustomerNumber->Text = "customerNumber: " + Convert::ToString(atm.customerNumber);
		lblAccountType->Text = "accountType: ";
		lblTransactionAmount->Text = "transactionAmount: ";
		break;
	}
}

private: System::Void btn1_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn1->Text;
}
private: System::Void btn2_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn2->Text;
}
private: System::Void btn3_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn3->Text;
}
private: System::Void btn4_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn4->Text;
}
private: System::Void btn5_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn5->Text;
}
private: System::Void btn6_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn6->Text;
}
private: System::Void btn7_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn7->Text;
}
private: System::Void btn8_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn8->Text;
}
private: System::Void btn9_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn9->Text;
}
private: System::Void btn0_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btn0->Text;
}
private: System::Void btnDot_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text += btnDot->Text;
}
private: System::Void btnCE_Click(System::Object^ sender, System::EventArgs^ e) {
	txtNumber->Text = "";
}
};
}