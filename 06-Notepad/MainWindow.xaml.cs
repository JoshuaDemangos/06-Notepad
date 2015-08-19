using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace _06_Notepad
{

    public partial class MainWindow : Window
    {
        private string CurrentFile;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {
            // Creates an OpenFileDialog object
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Calls the ShowDialog method defined in the OpenFileDialog class
            if (openFileDialog.ShowDialog() == true)
            {
                // Save the location of the file for later
                CurrentFile = openFileDialog.FileName;

                // Calls the static ReadAllText method defined in the File class 
                // to read the text contained in the file, and place it in a string.
                string fileContents = File.ReadAllText(CurrentFile);

                // Sets the Text property of our textWindow object to the contents of the file.
                textWindow.Text = fileContents;
            }
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // Calls the static WriteAllText method defined in the File class
            // to write the text in our textWindow object to the location we saved earlier
            File.WriteAllText(CurrentFile, textWindow.Text);

            // Shows a messagebox to tell the user our save worked
            MessageBox.Show("Save was successful");
        }
    }
}





