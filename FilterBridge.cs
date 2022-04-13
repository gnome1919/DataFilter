using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DataFilter
{
    public class FilterBridge
    
	{
		[DllImport("Filter.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		public static extern void LOWPASS([In] ref int TimeFormat, [In] ref int Nline, [In] ref int iorder, [In] ref double FC, [In] ref int[] MH, [In] ref int[] HH, [In] ref int[] DD, [In] ref int[] MM, [In] ref int[] YY, [In] ref int[] CC, [In] double[] elev, [In] ref int AnalysisType, [In] ref int WindowSize, [In] ref int ReSamPo1, [In] ref int ReSamInc, [In] ref int nl, [In] ref int nr, [In] ref int m, [In] ref double[] timesec, [Out] int[] MHs, [Out] int[] HHs, [Out] int[] DDs, [Out] int[] MMs, [Out] int[] YYs, [Out] int[] CCs, [Out] double[] timesecs, [Out] int number, [Out] double[] Elevs, [Out] double[] Elevo);

		//[DllImport("Inio_Eva_Engine.dll", CallingConvention = CallingConvention.Cdecl)]
		//public static extern void INIO_EVA_ENGINE();
	}
	
}


																																																																																																											