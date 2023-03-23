using Pinger;
using System.Net.NetworkInformation;
using System.Text;

//Pinging Google DNS Server 4.2.2.2

PingService pingService = new PingService();
var response = pingService.SendPing();
Console.WriteLine(response);