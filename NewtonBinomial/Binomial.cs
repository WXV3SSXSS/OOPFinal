using System.Text;

namespace NewtonBinomial
{
	/// <summary>
	/// Represents a class for calculating binomial coefficients and expanding binomial expressions.
	/// </summary>
	public class Binomial
	{
		/// <summary>
		/// Calculates the binomial expansion of (1 + x)^n using the Taylor series.
		/// </summary>
		/// <param name="n">The exponent in the binomial expression.</param>
		/// <returns>The expanded binomial expression as a string.</returns>
		public string CalculateBinomialTaylor(int n)
		{
			if (IsCorrectExponent(n))
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("(1+x)^" + n + " = ").Append("1 + ");
				for (int k = 1; k <= n; k++)
				{
					sb.Append(BinomialCoefficient(n, k) + "x^" + k + " + ").Append("x^").Append(k).Append(" + ");
				}
				sb.Remove(sb.Length - 3, 3);
				return sb.ToString();
			}
			return "";
		}
		/// <summary>
		/// Calculates the binomial expansion of (a + b)^n.
		/// </summary>
		/// <param name="n">The exponent in the binomial expression.</param>
		/// <returns>The expanded binomial expression as a string.</returns>
		public string CalculateBinomial(int n)
		{
			if (IsCorrectExponent(n))
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("(" + "a" + " + " + "b" + ")^" + n + " = ");
				for (int k = 0; k <= n; k++)
				{
					sb.Append(BinomialCoefficient(n, k) + " * " + "a" + "^" + (n - k) + " * " + "b" + "^" + k);
					if (k < n)
						sb.Append(" + ");
				}
				return sb.ToString();
			}
			return "";
		}
		/// <summary>
		/// Calculates the binomial coefficient C(n, k) using the formula n! / (k! * (n - k)!).
		/// </summary>
		/// <param name="n">n.</param>
		/// <param name="k">k.</param>
		/// <returns>The binomial coefficient C(n, k).</returns>
		private int BinomialCoefficient(int n, int k)
		{
		    int t = 1;
			for (int i = n - k + 1; i <= n; i++)
				t = t * i;
			for (int i = 2; i <= k; i++)
				t = t / i;
			return t;
		}

		private bool IsCorrectExponent(int n)
		{
			if (n > 0)
			{
				return true;
			}
			else
			{
                Console.WriteLine("Invalid exponent");
                return false;
			};
		}
	}
}