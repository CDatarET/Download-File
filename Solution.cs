using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
		    int n = int.Parse(inputs[0]);
		    int k = int.Parse(inputs[1]);
		    int sum = 0;
		    
		    for(int i = 0; i < n; i++){
		        string[] inps = Console.ReadLine().Split();
		        int t = int.Parse(inps[0]);
		        int d = int.Parse(inps[1]);
		        
		        if(k > 0 && k > t){
		            k = k - t;
		            t = 0;
		        }
		        else if(k > 0 && k <= t){
		            t = t - k;
		            k = 0;
		        }
		        
		        sum = sum + (t * d);
		    }
		    
		    Console.WriteLine(sum);
		}
	}
}
