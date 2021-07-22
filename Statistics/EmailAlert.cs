namespace Statistics
{
    public class EmailAlert : IAlert
    {
        public bool emailSent=false;

        public void Alert()
        {
            emailSent = true;
        }

    }
}
