﻿Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Module EngDescMdl

    ' Call this function to remove the key from memory after it is used for security.
    <DllImport("kernel32.dll")> _
    Public Sub ZeroMemory(ByVal addr As IntPtr, ByVal size As Integer)
    End Sub

    ' Function to generate a 64-bit key.
    Function GenerateKey() As String
        ' Create an instance of a symmetric algorithm. The key and the IV are generated automatically.
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()

        ' Use the automatically generated key for encryption. 
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)

    End Function

    Sub EncryptFile(ByVal sInputFilename As String, _
                   ByVal sOutputFilename As String, _
                   ByVal sKey As String)

        Dim fsInput As New FileStream(sInputFilename, _
                                    FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, _
                                    FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()

        'Set secret key for DES algorithm.
        'A 64-bit key and an IV are required for this provider.
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the DES encryptor from this instance.
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        'Create the crypto stream that transforms the file stream by using DES encryption.
        Dim cryptostream As New CryptoStream(fsEncrypted, _
                                            desencrypt, _
                                            CryptoStreamMode.Write)

        'Read the file text to the byte array.
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        'Write out the DES encrypted file.
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub

    Sub DecryptFile(ByVal sInputFilename As String, _
        ByVal sOutputFilename As String, _
        ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        'A 64-bit key and an IV are required for this provider.
        'Set the secret key for the DES algorithm.
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        'Set the initialization vector.
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)

        'Create the file stream to read the encrypted file back.
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        'Create the DES decryptor from the DES instance.
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        'Create the crypto stream set to read and to do a DES decryption transform on incoming bytes.
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        'Print out the contents of the decrypted file.
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

    Public Sub MyEncDesc(ByVal theFile As String, ByVal EncFile As String, ByVal DescFile As String)
        'Must be 64 bits, 8 bytes.
        Dim sSecretKey As String

        ' Get the key for the file to encrypt.
        ' You can distribute this key to the user who will decrypt the file.
        sSecretKey = GenerateKey()

        ' For additional security, pin the key.
        Dim gch As GCHandle = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned)


        ' Encrypt the file.        
        EncryptFile(theFile, _
                        EncFile, _
                        sSecretKey)

        ' Decrypt the file.
        DecryptFile(EncFile, _
                    DescFile, _
                    sSecretKey)

        ' Remove the key from memory. 
        ZeroMemory(gch.AddrOfPinnedObject(), sSecretKey.Length * 2)
        gch.Free()
    End Sub
End Module
