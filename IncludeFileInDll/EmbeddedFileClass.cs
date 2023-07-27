using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IncludeFileInDll
{
    public class EmbeddedFileClass
    {
        public static string GetEmbeddedTxtFileContent()
        {
            // Replace "YourNamespace" with the namespace where the .txt file is located.
            string resourceName = "IncludeFileInDll.TestFile.txt";

            // Get the current assembly.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Read the embedded resource and return its content.
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }

            // If the resource is not found, return null or an empty string, depending on your use case.
            return null;
        }        
    }
}
