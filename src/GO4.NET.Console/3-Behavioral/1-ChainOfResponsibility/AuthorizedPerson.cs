namespace GO4.NET.Console._3_Behavioral._1_ChainOfResponsibility
{
    public abstract class AuthorizedPerson
    {
        protected AuthorizedPerson _nextAuthorizedPerson;

        public void NextAuthorizedPerson(AuthorizedPerson authorizedPerson)
        {
            _nextAuthorizedPerson = authorizedPerson;
        }
        public abstract void AuthorizePaidTimeOff(string name, int amountDays);
    }
}
