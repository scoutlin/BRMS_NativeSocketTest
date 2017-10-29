using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestSocket
{
    public partial class Form1 : Form
    {
        Socket server = null;
        Socket handler = null;
        Socket client = null;

        public Form1()
        {
            InitializeComponent();
        }

        //private static void Send(Socket handler, String data)
        //{
        //    // Convert the string data to byte data using ASCII encoding.
        //    byte[] byteData = Encoding.ASCII.GetBytes(data);

        //    // Begin sending the data to the remote device.
        //    handler.BeginSend(byteData, 0, byteData.Length, 0,
        //        new AsyncCallback(SendCallback), handler);
        //}

        private static void ServerSendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ClientSendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }



        public static void ServerReceiveCallback(IAsyncResult ar)
        {
            try
            {
                String content = String.Empty;

                Socket handler = (Socket)ar.AsyncState;

                int bytesRead = handler.EndReceive(ar);

            }
            catch(Exception ex)
            {
                MessageBox.Show("ServerReceiveCallback: " + ex.ToString());
            }
        }

        public static void ClientReceiveCallback(IAsyncResult ar)
        {
            try
            {
                String content = String.Empty;

                Socket handler = (Socket)ar.AsyncState;

                int bytesRead = handler.EndReceive(ar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ClientReceiveCallback: " + ex.ToString());
            }
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

                server.Bind(localEndPoint);
                server.Listen(5000);

                server.BeginAccept(new AsyncCallback(AcceptCallback), server);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                 
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                //// Signal the main thread to continue.
                //AcceptDone.Set();

                // Get the socket that handles the client request.
                Socket listener = (Socket)ar.AsyncState;
                handler = listener.EndAccept(ar);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Server2_Click(object sender, EventArgs e)
        {
            byte[] byteData = Encoding.ASCII.GetBytes("Fuck");

            try
            {
                handler.BeginReceive(byteData, 0, 4, 0, new AsyncCallback(ServerReceiveCallback), handler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BeginReceive:" + ex.ToString());
            }
        }




        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);


                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP socket.
                client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_ClientClose_Click(object sender, EventArgs e)
        {
            client.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] byteData = Encoding.ASCII.GetBytes("Fuck");

            try
            {
                client.BeginReceive(byteData, 0, 4, 0, new AsyncCallback(ClientReceiveCallback), client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BeginReceive:" + ex.ToString());
            }
        }

        private void button_ServerClose_Click(object sender, EventArgs e)
        {
            server.Close();
        }

        private void button_ServerSend_Click(object sender, EventArgs e)
        {
            byte[] byteData = Encoding.ASCII.GetBytes("Fuck");

            try
            {
                handler.BeginSend(byteData, 0, 4, 0, new AsyncCallback(ServerSendCallback), handler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BeginSend:" + ex.ToString());
            }
        }

        private void button_ClientSend_Click(object sender, EventArgs e)
        {
            byte[] byteData = Encoding.ASCII.GetBytes("Fuck");

            try
            {
                client.BeginSend(byteData, 0, 4, 0, new AsyncCallback(ClientSendCallback), client);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BeginSend:" + ex.ToString());
            }
        }
    }
}
