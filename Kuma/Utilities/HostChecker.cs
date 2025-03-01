using System.Net.NetworkInformation;

namespace Kuma.Utilities
{
    public class HostChecker
    {
        public static bool IsHostAvailable(string host, out string status, out long roundtripTime)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(host);
                if (reply.Status == IPStatus.Success)
                {
                    status = reply.Status.ToString();
                    roundtripTime = reply.RoundtripTime;
                    return true;
                }
                else
                {
                    status = reply.Status.ToString();
                    roundtripTime = 0;
                    return false;
                }
            }
            catch (PingException ex)
            {
                status = "PingException: " + ex.Message;
                roundtripTime = 0;
                return false;
            }
            catch (Exception ex)
            {
                status = "Exception: " + ex.Message;
                roundtripTime = 0;
                return false;
            }
        }
    }
}
