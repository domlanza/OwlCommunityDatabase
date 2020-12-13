// Serializable File (Persistent Object)  Class 
// Responsible for all processing related to a Serializable File

using System;
using System.Windows.Forms;
// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;


namespace OwlCommunityMemberLanzaDrafts
{
    public static class SFManager
    {
        // This class manages s serializable file object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(OwlMemberList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.getCount() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Owl Member List not written", "SFManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    MessageBox.Show("File write: Owl Member List was written to serializable file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Owl Member List not written", "SFManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Owl Member in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Person List from file as a serialized binary object
        public static bool readFromFile(ref OwlMemberList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Owl Member List", "SFManager, File Open");
                    plist = new OwlMemberList();
                    return false;
                }  // end Try

                try
                {
                    plist = (OwlMemberList)deserializer.Deserialize(TestFileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Owl Member List", "SFManager File Read");
                    plist = new OwlMemberList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Owl Member List", "SF Manager Exists ");
                plist = new OwlMemberList();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end SFManager Class
}  // end namespace

