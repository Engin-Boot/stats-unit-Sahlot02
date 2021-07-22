namespace Statistics
{
    public class LedAlert : IAlert
    {
        public bool ledGlowing=false;

        public void Alert()
        {
            ledGlowing = true;
        }

    }
}
