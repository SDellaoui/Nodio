using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using IrrKlang;

namespace Nodio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create a new viewmodel for the NetworkView
            var network = new NetworkViewModel();

            //Create the node for the first node, set its name and add it to the network.
            var node1 = new NodeViewModel();
            node1.Name = "Node 1";
            network.Nodes.Add(node1);

            //Create the viewmodel for the input on the first node, set its name and add it to the node.
            var node1Input = new NodeInputViewModel();
            node1Input.Name = "Node 1 input";
            node1.Inputs.Add(node1Input);

            //Create the second node viewmodel, set its name, add it to the network and add an output in a similar fashion.
            var node2 = new NodeViewModel();
            node2.Name = "Node 2";
            network.Nodes.Add(node2);

            var node2Output = new NodeOutputViewModel();
            node2Output.Name = "Node 2 output";
            node2.Outputs.Add(node2Output);

            //Create a third test node

            var node3 = new NodeViewModel();
            node3.Name = "Test ";
            network.Nodes.Add(node3);

            var node3Input = new ValueNodeInputViewModel<string>();
            node3Input.Name = "Test String";
            node3.Inputs.Add(node3Input);

            //Assign the viewmodel to the view.
            networkView.ViewModel = network;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPlaySound_Click(object sender, RoutedEventArgs e)
        {
            ISoundEngine soundengine = new ISoundEngine();
            var projectPath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var soundPath = System.IO.Path.Combine(projectPath, "../data/sound");
            Console.WriteLine(projectPath);//Environment.CurrentDirectory);
            ISound sound = soundengine.Play2D(System.IO.Path.Combine(soundPath,"bell.wav"));
            sound.Looped = true;
        }
    }
}
