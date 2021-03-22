using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TcpServerClient {
    public partial class MainWindow : Window {
        TcpListener server;
        NetworkStream serverStream;
        TcpClient client;
        NetworkStream clientStream;

        public MainWindow() {
            InitializeComponent();
        }

        private void NewServerOutput(string output) {
            Dispatcher.Invoke(() => {
                outputBox.Text = outputBox.Text + output + "\n";
            });
        }

        private void NewClientOutput(string output) {
            Dispatcher.Invoke(() => {
                clientOutputBox.Text = clientOutputBox.Text + output + "\n";
            });
        }

        private void ServerStartListening(object obj) {
            TcpListener server = (TcpListener)obj;

            while (true) {
                TcpClient client = server.AcceptTcpClient();
                NewServerOutput("Client connected.");

                byte[] bytes = new byte[1024];

                serverStream = client.GetStream();

                int i;

                while ((i = serverStream.Read(bytes, 0, bytes.Length)) != 0) {
                    string data = Encoding.ASCII.GetString(bytes, 0, i);
                    NewServerOutput("Received: " + data);
                }

                client.Close();
            }
        }

        private void ClientStartListening(object obj) {
            TcpClient client = (TcpClient)obj;

            byte[] bytes = new byte[1024];

            clientStream = client.GetStream();

            int i;

            while ((i = clientStream.Read(bytes, 0, bytes.Length)) != 0) {
                string data = Encoding.ASCII.GetString(bytes, 0, i);
                NewClientOutput("Received: " + data);
            }

            clientStream.Close();
            client.Close();
        }

        private void portBox_TextChanged(object sender, TextChangedEventArgs e) {
            if (clientPortBox == null) return;
            clientPortBox.Text = portBox.Text;
        }

        private void portBox_GotFocus(object sender, RoutedEventArgs e) {
            if (portBox.Text == "Port") {
                portBox.Text = "";
            }
        }

        private void portBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(portBox.Text)) {
                portBox.Text = "Port";
            }
        }

        private void inputBox_GotFocus(object sender, RoutedEventArgs e) {
            if (inputBox.Text == "Data") {
                inputBox.Text = "";
            }
        }

        private void inputBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(inputBox.Text)) {
                inputBox.Text = "Data";
            }
        }

        private void clientPortBox_GotFocus(object sender, RoutedEventArgs e) {
            if (clientPortBox.Text == "Port") {
                clientPortBox.Text = "";
            }
        }

        private void clientPortBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(clientPortBox.Text)) {
                clientPortBox.Text = "Port";
            }
        }

        private void clientInputBox_GotFocus(object sender, RoutedEventArgs e) {
            if (clientInputBox.Text == "Data") {
                clientInputBox.Text = "";
            }
        }

        private void clientInputBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(clientInputBox.Text)) {
                clientInputBox.Text = "Data";
            }
        }

        private void startServerBtn_Click(object sender, RoutedEventArgs e) {
            if (server != null) {
                NewServerOutput("Already running server.");
                return;
            }

            try {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), int.Parse(portBox.Text));
                NewServerOutput("Started server.");
            } catch {
                NewServerOutput("Failed to start server. (Is your port correct?)");
                return;
            }

            server.Start();

            new Thread(new ParameterizedThreadStart(ServerStartListening)).Start(server);
        }

        private void connectClientBtn_Click(object sender, RoutedEventArgs e) {
            if (client != null) {
                NewClientOutput("Client already connected.");
                return;
            }

            try {
                client = new TcpClient("127.0.0.1", int.Parse(portBox.Text));
                NewClientOutput("Client connected.");
            } catch {
                NewClientOutput("Failed to connect client. (Is your port correct?)");
                return;
            }

            new Thread(new ParameterizedThreadStart(ClientStartListening)).Start(client);
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e) {
            if (client == null) {
                NewServerOutput("Server not running.");
                return;
            }

            byte[] data = Encoding.ASCII.GetBytes(inputBox.Text);

            serverStream.Write(data, 0, data.Length);
        }

        private void clientSendBtn_Click(object sender, RoutedEventArgs e) {
            if (client == null) {
                NewClientOutput("No client connected.");
                return;
            }

            byte[] data = Encoding.ASCII.GetBytes(clientInputBox.Text);

            clientStream.Write(data, 0, data.Length);
        }

        private void Window_Closed(object sender, EventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }
    }
}