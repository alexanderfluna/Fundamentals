// Form1.cpp
// Assignment 4
// Alexander Luna
// 4/28/2023
// Contains the main function for creating and running Form1

#include "Form1.h"
using namespace System;
using namespace System::Windows::Forms;
using namespace CppGUIPROJECT;


[STAThread]
int main(array<String^>^ argv)
{
	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	// Create the main window and run it
	Application::Run(gcnew Form1());

	return 0;
}