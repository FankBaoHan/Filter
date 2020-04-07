//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
	/// <summary>
	/// 1号模块谐波次数设置
	/// </summary>
    public partial class Harmonic4UnitOne
    {
		public void clear() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(0);
			Globals.Tags.harmonic_order1.SetAnalog(0);
			Globals.Tags.harmonic_order2.SetAnalog(0);
			Globals.Tags.harmonic_order3.SetAnalog(0);
			Globals.Tags.harmonic_order4.SetAnalog(0);
			
			Globals.Tags.harmonic_order5.SetAnalog(0);
			Globals.Tags.harmonic_order6.SetAnalog(0);
			Globals.Tags.harmonic_order7.SetAnalog(0);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(0);
			Globals.Tags.harmonic_order_per1.SetAnalog(0);
			Globals.Tags.harmonic_order_per2.SetAnalog(0);
			Globals.Tags.harmonic_order_per3.SetAnalog(0);
			Globals.Tags.harmonic_order_per4.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(0);
			Globals.Tags.harmonic_order_per6.SetAnalog(0);
			Globals.Tags.harmonic_order_per7.SetAnalog(0);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}

		public void oddOne() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(5);
			Globals.Tags.harmonic_order1.SetAnalog(7);
			Globals.Tags.harmonic_order2.SetAnalog(11);
			Globals.Tags.harmonic_order3.SetAnalog(13);
			Globals.Tags.harmonic_order4.SetAnalog(17);
			
			Globals.Tags.harmonic_order5.SetAnalog(19);
			Globals.Tags.harmonic_order6.SetAnalog(0);
			Globals.Tags.harmonic_order7.SetAnalog(0);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(100);
			Globals.Tags.harmonic_order_per1.SetAnalog(100);
			Globals.Tags.harmonic_order_per2.SetAnalog(100);
			Globals.Tags.harmonic_order_per3.SetAnalog(100);
			Globals.Tags.harmonic_order_per4.SetAnalog(100);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(100);
			Globals.Tags.harmonic_order_per6.SetAnalog(0);
			Globals.Tags.harmonic_order_per7.SetAnalog(0);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void oddTwo() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(5);
			Globals.Tags.harmonic_order1.SetAnalog(7);
			Globals.Tags.harmonic_order2.SetAnalog(11);
			Globals.Tags.harmonic_order3.SetAnalog(13);
			Globals.Tags.harmonic_order4.SetAnalog(17);
			
			Globals.Tags.harmonic_order5.SetAnalog(19);
			Globals.Tags.harmonic_order6.SetAnalog(23);
			Globals.Tags.harmonic_order7.SetAnalog(25);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(100);
			Globals.Tags.harmonic_order_per1.SetAnalog(100);
			Globals.Tags.harmonic_order_per2.SetAnalog(100);
			Globals.Tags.harmonic_order_per3.SetAnalog(100);
			Globals.Tags.harmonic_order_per4.SetAnalog(100);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(100);
			Globals.Tags.harmonic_order_per6.SetAnalog(100);
			Globals.Tags.harmonic_order_per7.SetAnalog(100);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void oddThree() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(3);
			Globals.Tags.harmonic_order1.SetAnalog(5);
			Globals.Tags.harmonic_order2.SetAnalog(7);
			Globals.Tags.harmonic_order3.SetAnalog(9);
			Globals.Tags.harmonic_order4.SetAnalog(11);
			
			Globals.Tags.harmonic_order5.SetAnalog(13);
			Globals.Tags.harmonic_order6.SetAnalog(15);
			Globals.Tags.harmonic_order7.SetAnalog(17);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(100);
			Globals.Tags.harmonic_order_per1.SetAnalog(100);
			Globals.Tags.harmonic_order_per2.SetAnalog(100);
			Globals.Tags.harmonic_order_per3.SetAnalog(100);
			Globals.Tags.harmonic_order_per4.SetAnalog(100);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(100);
			Globals.Tags.harmonic_order_per6.SetAnalog(100);
			Globals.Tags.harmonic_order_per7.SetAnalog(100);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void oddAll() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(3);
			Globals.Tags.harmonic_order1.SetAnalog(5);
			Globals.Tags.harmonic_order2.SetAnalog(7);
			Globals.Tags.harmonic_order3.SetAnalog(9);
			Globals.Tags.harmonic_order4.SetAnalog(11);
			
			Globals.Tags.harmonic_order5.SetAnalog(13);
			Globals.Tags.harmonic_order6.SetAnalog(15);
			Globals.Tags.harmonic_order7.SetAnalog(17);
			Globals.Tags.harmonic_order8.SetAnalog(19);
			Globals.Tags.harmonic_order9.SetAnalog(21);
			
			Globals.Tags.harmonic_order10.SetAnalog(23);
			Globals.Tags.harmonic_order11.SetAnalog(25);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(100);
			Globals.Tags.harmonic_order_per1.SetAnalog(100);
			Globals.Tags.harmonic_order_per2.SetAnalog(100);
			Globals.Tags.harmonic_order_per3.SetAnalog(100);
			Globals.Tags.harmonic_order_per4.SetAnalog(100);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(100);
			Globals.Tags.harmonic_order_per6.SetAnalog(100);
			Globals.Tags.harmonic_order_per7.SetAnalog(100);
			Globals.Tags.harmonic_order_per8.SetAnalog(100);
			Globals.Tags.harmonic_order_per9.SetAnalog(100);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(100);
			Globals.Tags.harmonic_order_per11.SetAnalog(100);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void sixPulse() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(6);
			Globals.Tags.harmonic_order1.SetAnalog(12);
			Globals.Tags.harmonic_order2.SetAnalog(18);
			Globals.Tags.harmonic_order3.SetAnalog(24);
			Globals.Tags.harmonic_order4.SetAnalog(0);
			
			Globals.Tags.harmonic_order5.SetAnalog(0);
			Globals.Tags.harmonic_order6.SetAnalog(0);
			Globals.Tags.harmonic_order7.SetAnalog(0);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(100);
			Globals.Tags.harmonic_order_per1.SetAnalog(100);
			Globals.Tags.harmonic_order_per2.SetAnalog(100);
			Globals.Tags.harmonic_order_per3.SetAnalog(100);
			Globals.Tags.harmonic_order_per4.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(0);
			Globals.Tags.harmonic_order_per6.SetAnalog(0);
			Globals.Tags.harmonic_order_per7.SetAnalog(0);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void harSrcOne() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(5);
			Globals.Tags.harmonic_order1.SetAnalog(7);
			Globals.Tags.harmonic_order2.SetAnalog(11);
			Globals.Tags.harmonic_order3.SetAnalog(13);
			Globals.Tags.harmonic_order4.SetAnalog(3);
			
			Globals.Tags.harmonic_order5.SetAnalog(9);
			Globals.Tags.harmonic_order6.SetAnalog(15);
			Globals.Tags.harmonic_order7.SetAnalog(0);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(20);
			Globals.Tags.harmonic_order_per1.SetAnalog(6);
			Globals.Tags.harmonic_order_per2.SetAnalog(5);
			Globals.Tags.harmonic_order_per3.SetAnalog(4);
			Globals.Tags.harmonic_order_per4.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(0);
			Globals.Tags.harmonic_order_per6.SetAnalog(0);
			Globals.Tags.harmonic_order_per7.SetAnalog(0);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
		
		public void harSrcTwo() {
			//次数
			Globals.Tags.harmonic_order0.SetAnalog(5);
			Globals.Tags.harmonic_order1.SetAnalog(7);
			Globals.Tags.harmonic_order2.SetAnalog(11);
			Globals.Tags.harmonic_order3.SetAnalog(13);
			Globals.Tags.harmonic_order4.SetAnalog(17);
			
			Globals.Tags.harmonic_order5.SetAnalog(19);
			Globals.Tags.harmonic_order6.SetAnalog(0);
			Globals.Tags.harmonic_order7.SetAnalog(0);
			Globals.Tags.harmonic_order8.SetAnalog(0);
			Globals.Tags.harmonic_order9.SetAnalog(0);
			
			Globals.Tags.harmonic_order10.SetAnalog(0);
			Globals.Tags.harmonic_order11.SetAnalog(0);
			Globals.Tags.harmonic_order12.SetAnalog(0);
			Globals.Tags.harmonic_order13.SetAnalog(0);
			Globals.Tags.harmonic_order14.SetAnalog(0);
			
			Globals.Tags.harmonic_order15.SetAnalog(0);
			Globals.Tags.harmonic_order16.SetAnalog(0);
			Globals.Tags.harmonic_order17.SetAnalog(0);
			Globals.Tags.harmonic_order18.SetAnalog(0);
			Globals.Tags.harmonic_order19.SetAnalog(0);
			
			//百分比
			Globals.Tags.harmonic_order_per0.SetAnalog(20);
			Globals.Tags.harmonic_order_per1.SetAnalog(6);
			Globals.Tags.harmonic_order_per2.SetAnalog(5);
			Globals.Tags.harmonic_order_per3.SetAnalog(4);
			Globals.Tags.harmonic_order_per4.SetAnalog(3);
			
			Globals.Tags.harmonic_order_per5.SetAnalog(2);
			Globals.Tags.harmonic_order_per6.SetAnalog(0);
			Globals.Tags.harmonic_order_per7.SetAnalog(0);
			Globals.Tags.harmonic_order_per8.SetAnalog(0);
			Globals.Tags.harmonic_order_per9.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per10.SetAnalog(0);
			Globals.Tags.harmonic_order_per11.SetAnalog(0);
			Globals.Tags.harmonic_order_per12.SetAnalog(0);
			Globals.Tags.harmonic_order_per13.SetAnalog(0);
			Globals.Tags.harmonic_order_per14.SetAnalog(0);
			
			Globals.Tags.harmonic_order_per15.SetAnalog(0);
			Globals.Tags.harmonic_order_per16.SetAnalog(0);
			Globals.Tags.harmonic_order_per17.SetAnalog(0);
			Globals.Tags.harmonic_order_per18.SetAnalog(0);
			Globals.Tags.harmonic_order_per19.SetAnalog(0);
		}
    }
}
