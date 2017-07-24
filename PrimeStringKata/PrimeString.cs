namespace PrimeStringKata
{
    public class PrimeString
    {
		public bool IsPrimeString(string inputString)
		{
			if (inputString.Length == 1)
			{
				return true;
			}
			for (var i = inputString.Length/2; i < inputString.Length ; i++)
			{
				if (inputString.Replace(inputString.Substring(i), string.Empty).Length == 0)
				{
					return false;
				}
			}
			return true;
		}
    }
}
