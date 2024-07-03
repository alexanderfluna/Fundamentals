#pragma once

using namespace System;
using namespace System::Security::Cryptography;
using namespace System::Text;

public ref class RijndaelEncryption
{
public:
    // key and initialization vector for the Rijndael algorithm
        // must be the same for encryption and decryption
    array<Byte>^ KEY = gcnew array<Byte>(32);
    array<Byte>^ IV = gcnew array<Byte>(16);

    static array<Byte>^ Encrypt(String^ message, array<Byte>^ key, array<Byte>^ iv)
    {
        array<Byte>^ encryptedMessage;

        RijndaelManaged^ aes = gcnew RijndaelManaged();
        aes->Key = key;
        aes->IV = iv;
        aes->Mode = CipherMode::CBC;

        ICryptoTransform^ encryptor = aes->CreateEncryptor(aes->Key, aes->IV);

        array<Byte>^ messageBytes = Encoding::UTF8->GetBytes(message);
        encryptedMessage = encryptor->TransformFinalBlock(messageBytes, 0, messageBytes->Length);

        return encryptedMessage;
    }

    static String^ Decrypt(array<Byte>^ encryptedMessage, array<Byte>^ key, array<Byte>^ iv)
    {
        String^ message;

        RijndaelManaged^ aes = gcnew RijndaelManaged();
        aes->Key = key;
        aes->IV = iv;
        aes->Mode = CipherMode::CBC;

        ICryptoTransform^ decryptor = aes->CreateDecryptor(aes->Key, aes->IV);

        array<Byte>^ decryptedBytes = decryptor->TransformFinalBlock(encryptedMessage, 0, encryptedMessage->Length);
        message = Encoding::UTF8->GetString(decryptedBytes);

        return message;
    }
};
