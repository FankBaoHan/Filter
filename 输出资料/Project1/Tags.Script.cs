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
    
    
    public partial class Tags
    {
		
		void err_1err_2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_1err_2.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr1[i].Value = (state&(1<<i))>0?true:false;
			//}	

			this.err1_0.Value = (state&(1<<0))>0?true:false;
			this.err1_1.Value = (state&(1<<1))>0?true:false;
			this.err1_2.Value = (state&(1<<2))>0?true:false;
			this.err1_3.Value = (state&(1<<3))>0?true:false;
			
			this.err1_4.Value = (state&(1<<4))>0?true:false;
			this.err1_5.Value = (state&(1<<5))>0?true:false;
			this.err1_6.Value = (state&(1<<6))>0?true:false;
			this.err1_7.Value = (state&(1<<7))>0?true:false;
			
			this.err1_8.Value = (state&(1<<8))>0?true:false;
			this.err1_9.Value = (state&(1<<9))>0?true:false;
			this.err1_10.Value = (state&(1<<10))>0?true:false;
			this.err1_11.Value = (state&(1<<11))>0?true:false;
			
			this.err1_12.Value = (state&(1<<12))>0?true:false;
			this.err1_13.Value = (state&(1<<13))>0?true:false;
			this.err1_14.Value = (state&(1<<14))>0?true:false;
			this.err1_15.Value = (state&(1<<15))>0?true:false;
		}
		
		void err_3err_4_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_3err_4.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr2[i].Value = (state&(1<<i))>0?true:false;
			//}
			
			this.err2_0.Value = (state&(1<<0))>0?true:false;
			this.err2_1.Value = (state&(1<<1))>0?true:false;
			this.err2_2.Value = (state&(1<<2))>0?true:false;
			this.err2_3.Value = (state&(1<<3))>0?true:false;
			
			this.err2_4.Value = (state&(1<<4))>0?true:false;
			this.err2_5.Value = (state&(1<<5))>0?true:false;
			this.err2_6.Value = (state&(1<<6))>0?true:false;
			this.err2_7.Value = (state&(1<<7))>0?true:false;
			
			this.err2_8.Value = (state&(1<<8))>0?true:false;
			this.err2_9.Value = (state&(1<<9))>0?true:false;
			this.err2_10.Value = (state&(1<<10))>0?true:false;
			this.err2_11.Value = (state&(1<<11))>0?true:false;
			
			this.err2_12.Value = (state&(1<<12))>0?true:false;
			this.err2_13.Value = (state&(1<<13))>0?true:false;
			this.err2_14.Value = (state&(1<<14))>0?true:false;
			this.err2_15.Value = (state&(1<<15))>0?true:false;
		}
		
		void err_5err_6_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_5err_6.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr3[i].Value = (state&(1<<i))>0?true:false;
			//}
		
			this.err3_0.Value = (state&(1<<0))>0?true:false;
			this.err3_1.Value = (state&(1<<1))>0?true:false;
			this.err3_2.Value = (state&(1<<2))>0?true:false;
			this.err3_3.Value = (state&(1<<3))>0?true:false;
			
			this.err3_4.Value = (state&(1<<4))>0?true:false;
			this.err3_5.Value = (state&(1<<5))>0?true:false;
			this.err3_6.Value = (state&(1<<6))>0?true:false;
			this.err3_7.Value = (state&(1<<7))>0?true:false;
			
			this.err3_8.Value = (state&(1<<8))>0?true:false;
			this.err3_9.Value = (state&(1<<9))>0?true:false;
			this.err3_10.Value = (state&(1<<10))>0?true:false;
			this.err3_11.Value = (state&(1<<11))>0?true:false;
			
			this.err3_12.Value = (state&(1<<12))>0?true:false;
			this.err3_13.Value = (state&(1<<13))>0?true:false;
			this.err3_14.Value = (state&(1<<14))>0?true:false;
			this.err3_15.Value = (state&(1<<15))>0?true:false;
		}
		
		void SystemTagCommunicationErrorMessage_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			//通讯故障
			Neo.ApplicationFramework.Tools.OpcClient.SystemDataItem item = (Neo.ApplicationFramework.Tools.OpcClient.SystemDataItem)sender;
			String msg = item.Value.String.ToLower();
			
			if (msg.Contains("comm err")) {
				if (msg.Contains("filter")) {

				}
			}
		}
		
		void err_1err_2_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_1err_2_f2.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr1[i].Value = (state&(1<<i))>0?true:false;
			//}	

			this.err1_0_f2.Value = (state&(1<<0))>0?true:false;
			this.err1_1_f2.Value = (state&(1<<1))>0?true:false;
			this.err1_2_f2.Value = (state&(1<<2))>0?true:false;
			this.err1_3_f2.Value = (state&(1<<3))>0?true:false;
			
			this.err1_4_f2.Value = (state&(1<<4))>0?true:false;
			this.err1_5_f2.Value = (state&(1<<5))>0?true:false;
			this.err1_6_f2.Value = (state&(1<<6))>0?true:false;
			this.err1_7_f2.Value = (state&(1<<7))>0?true:false;
			
			this.err1_8_f2.Value = (state&(1<<8))>0?true:false;
			this.err1_9_f2.Value = (state&(1<<9))>0?true:false;
			this.err1_10_f2.Value = (state&(1<<10))>0?true:false;
			this.err1_11_f2.Value = (state&(1<<11))>0?true:false;
			
			this.err1_12_f2.Value = (state&(1<<12))>0?true:false;
			this.err1_13_f2.Value = (state&(1<<13))>0?true:false;
			this.err1_14_f2.Value = (state&(1<<14))>0?true:false;
			this.err1_15_f2.Value = (state&(1<<15))>0?true:false;
		}
		
		void err_3err_4_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_3err_4_f2.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr2[i].Value = (state&(1<<i))>0?true:false;
			//}
			
			this.err2_0_f2.Value = (state&(1<<0))>0?true:false;
			this.err2_1_f2.Value = (state&(1<<1))>0?true:false;
			this.err2_2_f2.Value = (state&(1<<2))>0?true:false;
			this.err2_3_f2.Value = (state&(1<<3))>0?true:false;
			
			this.err2_4_f2.Value = (state&(1<<4))>0?true:false;
			this.err2_5_f2.Value = (state&(1<<5))>0?true:false;
			this.err2_6_f2.Value = (state&(1<<6))>0?true:false;
			this.err2_7_f2.Value = (state&(1<<7))>0?true:false;
			
			this.err2_8_f2.Value = (state&(1<<8))>0?true:false;
			this.err2_9_f2.Value = (state&(1<<9))>0?true:false;
			this.err2_10_f2.Value = (state&(1<<10))>0?true:false;
			this.err2_11_f2.Value = (state&(1<<11))>0?true:false;
			
			this.err2_12_f2.Value = (state&(1<<12))>0?true:false;
			this.err2_13_f2.Value = (state&(1<<13))>0?true:false;
			this.err2_14_f2.Value = (state&(1<<14))>0?true:false;
			this.err2_15_f2.Value = (state&(1<<15))>0?true:false;
		}
		
		void err_5err_6_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			uint state = this.err_5err_6_f2.Value.UInt;
			
			//for (int i = 0; i < 16; i++) {
			//	this.arrayErr3[i].Value = (state&(1<<i))>0?true:false;
			//}
		
			this.err3_0_f2.Value = (state&(1<<0))>0?true:false;
			this.err3_1_f2.Value = (state&(1<<1))>0?true:false;
			this.err3_2_f2.Value = (state&(1<<2))>0?true:false;
			this.err3_3_f2.Value = (state&(1<<3))>0?true:false;
			
			this.err3_4_f2.Value = (state&(1<<4))>0?true:false;
			this.err3_5_f2.Value = (state&(1<<5))>0?true:false;
			this.err3_6_f2.Value = (state&(1<<6))>0?true:false;
			this.err3_7_f2.Value = (state&(1<<7))>0?true:false;
			
			this.err3_8_f2.Value = (state&(1<<8))>0?true:false;
			this.err3_9_f2.Value = (state&(1<<9))>0?true:false;
			this.err3_10_f2.Value = (state&(1<<10))>0?true:false;
			this.err3_11_f2.Value = (state&(1<<11))>0?true:false;
			
			this.err3_12_f2.Value = (state&(1<<12))>0?true:false;
			this.err3_13_f2.Value = (state&(1<<13))>0?true:false;
			this.err3_14_f2.Value = (state&(1<<14))>0?true:false;
			this.err3_15_f2.Value = (state&(1<<15))>0?true:false;
		}
		
		//设置从站地址寄存器
		void index_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.slave_address.Value = Globals.Tags.index.Value;
		}
		
		//蜂鸣器：常开
		void buzzer_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(buzzer.Value == 1) 
			{
				DO_M.Value |=  1<<1 ;
			}
			else if(buzzer.Value == 0) 
			{
				DO_M.Value &= ((1 << 1) ^ 0xff);
			}
		}
		
		//指示灯
		void flicker_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(flicker.Value == 1) 
			{
				DO_M.Value |=  1<<0 ;
			}
			else if(flicker.Value == 0) 
			{
				DO_M.Value &= ((1 << 0) ^ 0xff);
			}
		}
		
		// * 1.732
		void dis_usa_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usa_173_f1.Value = dis_usa.Value * 1.732;
		}
		
		void dis_usb_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usb_173_f1.Value = dis_usb.Value * 1.732;
		}
		
		void dis_usc_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usc_173_f1.Value = dis_usc.Value * 1.732;
		}
		
		void dis_usc_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usc_173_f2.Value = dis_usc_f2.Value * 1.732;
		}
		
		void dis_usb_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usb_173_f2.Value = dis_usb_f2.Value * 1.732;
		}
		
		void dis_usa_f2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			dis_usa_173_f2.Value = dis_usa_f2.Value * 1.732;
		}
		
		
		

		
		
    }
}
