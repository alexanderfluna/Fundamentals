// ClassLibrary1.h

#pragma once

using namespace System;

namespace NetLibrary {

	public ref class CharacterCasing
	{
		// TODO: Add your methods for this class here.
	public:
		String^ UpperCase(String^ text)
		{
			return text->ToUpper();
		}
		String^ LowerCase(String^ text)
		{
			return text->ToLower();
		}
	};
}
