using System;
using System.Collections.Generic;

namespace HandlingExceptions
{
	class Program
	{
		public static void Main(string[] args)
		{
			#region Simple Try Catch

			//try
			//{
			//Console.WriteLine("Enter First Number:");
			//int a = int.Parse(Console.ReadLine());

			//Console.WriteLine("Enter Second Number:");
			//int b = int.Parse(Console.ReadLine());
			//Console.WriteLine("The division is:" + a/b);
			//}
			//catch (DivideByZeroException ex)
			//{

			//Console.WriteLine(ex.Message);
			//Console.WriteLine(ex.InnerException);
			//Console.WriteLine(ex.StackTrace);
			//}
			#endregion

			#region IndexOutOfRangeException
			//try
			//{
			//	int[] ints = new int[3];
			//	ints[1] = 11;
			//	ints[2] = 12;
			//	ints[3] = 14;
			//	ints[4] = 15;
			//}
			//catch (IndexOutOfRangeException ex)
			//{

			//	Console.WriteLine(ex);
			//}
			#endregion

			#region NullReferenceException
			//try
			//{
			//	string name = null;
			//	Console.WriteLine(name.Count());
			//}
			//catch (NullReferenceException ex)
			//{
			//	Console.WriteLine(ex.Message);
			//	Console.WriteLine(ex);
			//}
			#endregion

			#region FormatException
			//try
			//{
			//	int a = int.Parse(Console.ReadLine());
			//	Console.WriteLine(a);

			//}
			//catch (FormatException ex)
			//{

			//	Console.WriteLine(ex);
			//}
			#endregion

			#region HandlingMultipleExceptionsWithFinallyBlock
			try
			{
				Console.WriteLine("Enter First Number:");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter Second Number:");
				int b = int.Parse(Console.ReadLine());
				Console.WriteLine("The division is:" + a / b);
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(ex.Message+ ex.TargetSite);
			}
			catch (ApplicationException ex)
			{
				Console.WriteLine(ex);
			}
			catch(IndexOutOfRangeException ex) 
			{
				Console.WriteLine(ex);
			}
			catch(DivideByZeroException ex) 
			{
				Console.WriteLine(ex);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Finally Block Executed");
			}
			#endregion




		}
	}
}
