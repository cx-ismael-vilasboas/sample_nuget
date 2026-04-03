using System;
using System.Collections.Specialized;
using System.IO;
using DotNetCasClient.Utils;
using Thrift.Protocol;
using Opc.Ua;
using WindowsHello;

namespace ExploitablePath
{
    public class Program
    {
        static TProtocol prot;

        static void TestSkip()
        {
            TProtocolUtil.Skip(prot, TType.Stop);
        }

        public Program()
        {
            var decoder = new BinaryDecoder(Stream.Null, ServiceMessageContext.GlobalContext);
            decoder.ReadExtensionObject("field");
            UrlUtil.ConstructValidateUrl("https://mockurl.com", true, false, new NameValueCollection());
            UrlUtilTest();
        }

        static void TestReadExtensionObjectFunc()
        {
            var decoder = new BinaryDecoder(Stream.Null, ServiceMessageContext.GlobalContext);
            decoder.ReadExtensionObject("field");
        }

        void UrlUtilTest()
        {
            UrlUtil.ConstructServiceUrl(true);
            UrlUtil.ConstructValidateUrl("https://mockurl.com", true, false, new NameValueCollection());
        }

        public static void Main()
        {
            TestReadExtensionObjectFunc();
        }

        public void WindowsHelloTest()
        {
            var handle = new IntPtr();
            var data = new byte[] {0x32, 0x32};
            var provider = new WinHelloProvider("Hello", handle);
            var encryptedData = provider.Encrypt(data);
            var decryptedData = provider.PromptToDecrypt(encryptedData);
        }
    }
}