namespace Task
{
   public class NotAnEmailAdressException : Exception
   {
        public NotAnEmailAdressException() { }
        public NotAnEmailAdressException(string name) : base(name)
        {
            
        }
    }
    public class ArgumentOutOfRangeException : Exception
    {
        public ArgumentOutOfRangeException() { }
        public ArgumentOutOfRangeException(string name) : base(name)
        {

        }
    }



    public class EmailValidator
    {
        public bool Validate (string email)
        {
            if (!email.EndsWith("mail.com"))
            {
                throw new NotAnEmailAdressException("Error");
            }
            if (email.Length > 9)
            {
                throw new ArgumentOutOfRangeException("Error");
            }
            return true;
           
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           var emailvalidator = new EmailValidator();
            

            try
            {
                emailvalidator.Validate("fazilbehramov@maill.ru");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
            
        }
    }
}