using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Model.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/event/WellnessDailyStats", DoNotGenerateAcw=true)]
	public partial class WellnessDailyStats : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/event/WellnessDailyStats", typeof (WellnessDailyStats));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected WellnessDailyStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/constructor[@name='WellnessDailyStats' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WellnessDailyStats ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getActiveCalories;
#pragma warning disable 0169
		static Delegate GetGetActiveCaloriesHandler ()
		{
			if (cb_getActiveCalories == null)
				cb_getActiveCalories = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetActiveCalories);
			return cb_getActiveCalories;
		}

		static double n_GetActiveCalories (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveCalories;
		}
#pragma warning restore 0169

		static Delegate cb_setActiveCalories_D;
#pragma warning disable 0169
		static Delegate GetSetActiveCalories_DHandler ()
		{
			if (cb_setActiveCalories_D == null)
				cb_setActiveCalories_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetActiveCalories_D);
			return cb_setActiveCalories_D;
		}

		static void n_SetActiveCalories_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActiveCalories = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double ActiveCalories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getActiveCalories' and count(parameter)=0]"
			[Register ("getActiveCalories", "()D", "GetGetActiveCaloriesHandler")]
			get {
				const string __id = "getActiveCalories.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setActiveCalories' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setActiveCalories", "(D)V", "GetSetActiveCalories_DHandler")]
			set {
				const string __id = "setActiveCalories.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getActiveMinutes;
#pragma warning disable 0169
		static Delegate GetGetActiveMinutesHandler ()
		{
			if (cb_getActiveMinutes == null)
				cb_getActiveMinutes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetActiveMinutes);
			return cb_getActiveMinutes;
		}

		static int n_GetActiveMinutes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveMinutes;
		}
#pragma warning restore 0169

		static Delegate cb_setActiveMinutes_I;
#pragma warning disable 0169
		static Delegate GetSetActiveMinutes_IHandler ()
		{
			if (cb_setActiveMinutes_I == null)
				cb_setActiveMinutes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetActiveMinutes_I);
			return cb_setActiveMinutes_I;
		}

		static void n_SetActiveMinutes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActiveMinutes = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ActiveMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getActiveMinutes' and count(parameter)=0]"
			[Register ("getActiveMinutes", "()I", "GetGetActiveMinutesHandler")]
			get {
				const string __id = "getActiveMinutes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setActiveMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActiveMinutes", "(I)V", "GetSetActiveMinutes_IHandler")]
			set {
				const string __id = "setActiveMinutes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAverageHeartRate;
#pragma warning disable 0169
		static Delegate GetGetAverageHeartRateHandler ()
		{
			if (cb_getAverageHeartRate == null)
				cb_getAverageHeartRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAverageHeartRate);
			return cb_getAverageHeartRate;
		}

		static int n_GetAverageHeartRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageHeartRate;
		}
#pragma warning restore 0169

		static Delegate cb_setAverageHeartRate_I;
#pragma warning disable 0169
		static Delegate GetSetAverageHeartRate_IHandler ()
		{
			if (cb_setAverageHeartRate_I == null)
				cb_setAverageHeartRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAverageHeartRate_I);
			return cb_setAverageHeartRate_I;
		}

		static void n_SetAverageHeartRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AverageHeartRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int AverageHeartRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getAverageHeartRate' and count(parameter)=0]"
			[Register ("getAverageHeartRate", "()I", "GetGetAverageHeartRateHandler")]
			get {
				const string __id = "getAverageHeartRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setAverageHeartRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAverageHeartRate", "(I)V", "GetSetAverageHeartRate_IHandler")]
			set {
				const string __id = "setAverageHeartRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAverageRespirationRate;
#pragma warning disable 0169
		static Delegate GetGetAverageRespirationRateHandler ()
		{
			if (cb_getAverageRespirationRate == null)
				cb_getAverageRespirationRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAverageRespirationRate);
			return cb_getAverageRespirationRate;
		}

		static int n_GetAverageRespirationRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageRespirationRate;
		}
#pragma warning restore 0169

		static Delegate cb_setAverageRespirationRate_I;
#pragma warning disable 0169
		static Delegate GetSetAverageRespirationRate_IHandler ()
		{
			if (cb_setAverageRespirationRate_I == null)
				cb_setAverageRespirationRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAverageRespirationRate_I);
			return cb_setAverageRespirationRate_I;
		}

		static void n_SetAverageRespirationRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AverageRespirationRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int AverageRespirationRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getAverageRespirationRate' and count(parameter)=0]"
			[Register ("getAverageRespirationRate", "()I", "GetGetAverageRespirationRateHandler")]
			get {
				const string __id = "getAverageRespirationRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setAverageRespirationRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAverageRespirationRate", "(I)V", "GetSetAverageRespirationRate_IHandler")]
			set {
				const string __id = "setAverageRespirationRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDailyRecover;
#pragma warning disable 0169
		static Delegate GetGetDailyRecoverHandler ()
		{
			if (cb_getDailyRecover == null)
				cb_getDailyRecover = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetDailyRecover);
			return cb_getDailyRecover;
		}

		static double n_GetDailyRecover (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DailyRecover;
		}
#pragma warning restore 0169

		static Delegate cb_setDailyRecover_D;
#pragma warning disable 0169
		static Delegate GetSetDailyRecover_DHandler ()
		{
			if (cb_setDailyRecover_D == null)
				cb_setDailyRecover_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetDailyRecover_D);
			return cb_setDailyRecover_D;
		}

		static void n_SetDailyRecover_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DailyRecover = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double DailyRecover {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getDailyRecover' and count(parameter)=0]"
			[Register ("getDailyRecover", "()D", "GetGetDailyRecoverHandler")]
			get {
				const string __id = "getDailyRecover.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setDailyRecover' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDailyRecover", "(D)V", "GetSetDailyRecover_DHandler")]
			set {
				const string __id = "setDailyRecover.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDailyStress;
#pragma warning disable 0169
		static Delegate GetGetDailyStressHandler ()
		{
			if (cb_getDailyStress == null)
				cb_getDailyStress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetDailyStress);
			return cb_getDailyStress;
		}

		static double n_GetDailyStress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DailyStress;
		}
#pragma warning restore 0169

		static Delegate cb_setDailyStress_D;
#pragma warning disable 0169
		static Delegate GetSetDailyStress_DHandler ()
		{
			if (cb_setDailyStress_D == null)
				cb_setDailyStress_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetDailyStress_D);
			return cb_setDailyStress_D;
		}

		static void n_SetDailyStress_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DailyStress = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double DailyStress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getDailyStress' and count(parameter)=0]"
			[Register ("getDailyStress", "()D", "GetGetDailyStressHandler")]
			get {
				const string __id = "getDailyStress.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setDailyStress' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDailyStress", "(D)V", "GetSetDailyStress_DHandler")]
			set {
				const string __id = "setDailyStress.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighestCalories;
#pragma warning disable 0169
		static Delegate GetGetHighestCaloriesHandler ()
		{
			if (cb_getHighestCalories == null)
				cb_getHighestCalories = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetHighestCalories);
			return cb_getHighestCalories;
		}

		static double n_GetHighestCalories (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestCalories;
		}
#pragma warning restore 0169

		static Delegate cb_setHighestCalories_D;
#pragma warning disable 0169
		static Delegate GetSetHighestCalories_DHandler ()
		{
			if (cb_setHighestCalories_D == null)
				cb_setHighestCalories_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetHighestCalories_D);
			return cb_setHighestCalories_D;
		}

		static void n_SetHighestCalories_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighestCalories = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double HighestCalories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getHighestCalories' and count(parameter)=0]"
			[Register ("getHighestCalories", "()D", "GetGetHighestCaloriesHandler")]
			get {
				const string __id = "getHighestCalories.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setHighestCalories' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setHighestCalories", "(D)V", "GetSetHighestCalories_DHandler")]
			set {
				const string __id = "setHighestCalories.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighestHeartRate;
#pragma warning disable 0169
		static Delegate GetGetHighestHeartRateHandler ()
		{
			if (cb_getHighestHeartRate == null)
				cb_getHighestHeartRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHighestHeartRate);
			return cb_getHighestHeartRate;
		}

		static int n_GetHighestHeartRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestHeartRate;
		}
#pragma warning restore 0169

		static Delegate cb_setHighestHeartRate_I;
#pragma warning disable 0169
		static Delegate GetSetHighestHeartRate_IHandler ()
		{
			if (cb_setHighestHeartRate_I == null)
				cb_setHighestHeartRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHighestHeartRate_I);
			return cb_setHighestHeartRate_I;
		}

		static void n_SetHighestHeartRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighestHeartRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int HighestHeartRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getHighestHeartRate' and count(parameter)=0]"
			[Register ("getHighestHeartRate", "()I", "GetGetHighestHeartRateHandler")]
			get {
				const string __id = "getHighestHeartRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setHighestHeartRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighestHeartRate", "(I)V", "GetSetHighestHeartRate_IHandler")]
			set {
				const string __id = "setHighestHeartRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighestRecover;
#pragma warning disable 0169
		static Delegate GetGetHighestRecoverHandler ()
		{
			if (cb_getHighestRecover == null)
				cb_getHighestRecover = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetHighestRecover);
			return cb_getHighestRecover;
		}

		static double n_GetHighestRecover (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestRecover;
		}
#pragma warning restore 0169

		static Delegate cb_setHighestRecover_D;
#pragma warning disable 0169
		static Delegate GetSetHighestRecover_DHandler ()
		{
			if (cb_setHighestRecover_D == null)
				cb_setHighestRecover_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetHighestRecover_D);
			return cb_setHighestRecover_D;
		}

		static void n_SetHighestRecover_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighestRecover = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double HighestRecover {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getHighestRecover' and count(parameter)=0]"
			[Register ("getHighestRecover", "()D", "GetGetHighestRecoverHandler")]
			get {
				const string __id = "getHighestRecover.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setHighestRecover' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setHighestRecover", "(D)V", "GetSetHighestRecover_DHandler")]
			set {
				const string __id = "setHighestRecover.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighestRespirationRate;
#pragma warning disable 0169
		static Delegate GetGetHighestRespirationRateHandler ()
		{
			if (cb_getHighestRespirationRate == null)
				cb_getHighestRespirationRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHighestRespirationRate);
			return cb_getHighestRespirationRate;
		}

		static int n_GetHighestRespirationRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestRespirationRate;
		}
#pragma warning restore 0169

		static Delegate cb_setHighestRespirationRate_I;
#pragma warning disable 0169
		static Delegate GetSetHighestRespirationRate_IHandler ()
		{
			if (cb_setHighestRespirationRate_I == null)
				cb_setHighestRespirationRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHighestRespirationRate_I);
			return cb_setHighestRespirationRate_I;
		}

		static void n_SetHighestRespirationRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighestRespirationRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int HighestRespirationRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getHighestRespirationRate' and count(parameter)=0]"
			[Register ("getHighestRespirationRate", "()I", "GetGetHighestRespirationRateHandler")]
			get {
				const string __id = "getHighestRespirationRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setHighestRespirationRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighestRespirationRate", "(I)V", "GetSetHighestRespirationRate_IHandler")]
			set {
				const string __id = "setHighestRespirationRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighestStress;
#pragma warning disable 0169
		static Delegate GetGetHighestStressHandler ()
		{
			if (cb_getHighestStress == null)
				cb_getHighestStress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetHighestStress);
			return cb_getHighestStress;
		}

		static double n_GetHighestStress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestStress;
		}
#pragma warning restore 0169

		static Delegate cb_setHighestStress_D;
#pragma warning disable 0169
		static Delegate GetSetHighestStress_DHandler ()
		{
			if (cb_setHighestStress_D == null)
				cb_setHighestStress_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetHighestStress_D);
			return cb_setHighestStress_D;
		}

		static void n_SetHighestStress_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighestStress = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double HighestStress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getHighestStress' and count(parameter)=0]"
			[Register ("getHighestStress", "()D", "GetGetHighestStressHandler")]
			get {
				const string __id = "getHighestStress.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setHighestStress' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setHighestStress", "(D)V", "GetSetHighestStress_DHandler")]
			set {
				const string __id = "setHighestStress.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestCalories;
#pragma warning disable 0169
		static Delegate GetGetLowestCaloriesHandler ()
		{
			if (cb_getLowestCalories == null)
				cb_getLowestCalories = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetLowestCalories);
			return cb_getLowestCalories;
		}

		static double n_GetLowestCalories (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestCalories;
		}
#pragma warning restore 0169

		static Delegate cb_setLowestCalories_D;
#pragma warning disable 0169
		static Delegate GetSetLowestCalories_DHandler ()
		{
			if (cb_setLowestCalories_D == null)
				cb_setLowestCalories_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetLowestCalories_D);
			return cb_setLowestCalories_D;
		}

		static void n_SetLowestCalories_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowestCalories = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double LowestCalories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getLowestCalories' and count(parameter)=0]"
			[Register ("getLowestCalories", "()D", "GetGetLowestCaloriesHandler")]
			get {
				const string __id = "getLowestCalories.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setLowestCalories' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLowestCalories", "(D)V", "GetSetLowestCalories_DHandler")]
			set {
				const string __id = "setLowestCalories.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestHeartRate;
#pragma warning disable 0169
		static Delegate GetGetLowestHeartRateHandler ()
		{
			if (cb_getLowestHeartRate == null)
				cb_getLowestHeartRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLowestHeartRate);
			return cb_getLowestHeartRate;
		}

		static int n_GetLowestHeartRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestHeartRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLowestHeartRate_I;
#pragma warning disable 0169
		static Delegate GetSetLowestHeartRate_IHandler ()
		{
			if (cb_setLowestHeartRate_I == null)
				cb_setLowestHeartRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLowestHeartRate_I);
			return cb_setLowestHeartRate_I;
		}

		static void n_SetLowestHeartRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowestHeartRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int LowestHeartRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getLowestHeartRate' and count(parameter)=0]"
			[Register ("getLowestHeartRate", "()I", "GetGetLowestHeartRateHandler")]
			get {
				const string __id = "getLowestHeartRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setLowestHeartRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLowestHeartRate", "(I)V", "GetSetLowestHeartRate_IHandler")]
			set {
				const string __id = "setLowestHeartRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestRecover;
#pragma warning disable 0169
		static Delegate GetGetLowestRecoverHandler ()
		{
			if (cb_getLowestRecover == null)
				cb_getLowestRecover = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetLowestRecover);
			return cb_getLowestRecover;
		}

		static double n_GetLowestRecover (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestRecover;
		}
#pragma warning restore 0169

		static Delegate cb_setLowestRecover_D;
#pragma warning disable 0169
		static Delegate GetSetLowestRecover_DHandler ()
		{
			if (cb_setLowestRecover_D == null)
				cb_setLowestRecover_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetLowestRecover_D);
			return cb_setLowestRecover_D;
		}

		static void n_SetLowestRecover_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowestRecover = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double LowestRecover {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getLowestRecover' and count(parameter)=0]"
			[Register ("getLowestRecover", "()D", "GetGetLowestRecoverHandler")]
			get {
				const string __id = "getLowestRecover.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setLowestRecover' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLowestRecover", "(D)V", "GetSetLowestRecover_DHandler")]
			set {
				const string __id = "setLowestRecover.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestRespirationRate;
#pragma warning disable 0169
		static Delegate GetGetLowestRespirationRateHandler ()
		{
			if (cb_getLowestRespirationRate == null)
				cb_getLowestRespirationRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLowestRespirationRate);
			return cb_getLowestRespirationRate;
		}

		static int n_GetLowestRespirationRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestRespirationRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLowestRespirationRate_I;
#pragma warning disable 0169
		static Delegate GetSetLowestRespirationRate_IHandler ()
		{
			if (cb_setLowestRespirationRate_I == null)
				cb_setLowestRespirationRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLowestRespirationRate_I);
			return cb_setLowestRespirationRate_I;
		}

		static void n_SetLowestRespirationRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowestRespirationRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int LowestRespirationRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getLowestRespirationRate' and count(parameter)=0]"
			[Register ("getLowestRespirationRate", "()I", "GetGetLowestRespirationRateHandler")]
			get {
				const string __id = "getLowestRespirationRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setLowestRespirationRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLowestRespirationRate", "(I)V", "GetSetLowestRespirationRate_IHandler")]
			set {
				const string __id = "setLowestRespirationRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestStress;
#pragma warning disable 0169
		static Delegate GetGetLowestStressHandler ()
		{
			if (cb_getLowestStress == null)
				cb_getLowestStress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetLowestStress);
			return cb_getLowestStress;
		}

		static double n_GetLowestStress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestStress;
		}
#pragma warning restore 0169

		static Delegate cb_setLowestStress_D;
#pragma warning disable 0169
		static Delegate GetSetLowestStress_DHandler ()
		{
			if (cb_setLowestStress_D == null)
				cb_setLowestStress_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetLowestStress_D);
			return cb_setLowestStress_D;
		}

		static void n_SetLowestStress_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowestStress = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double LowestStress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getLowestStress' and count(parameter)=0]"
			[Register ("getLowestStress", "()D", "GetGetLowestStressHandler")]
			get {
				const string __id = "getLowestStress.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setLowestStress' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLowestStress", "(D)V", "GetSetLowestStress_DHandler")]
			set {
				const string __id = "setLowestStress.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecoverMinutes;
#pragma warning disable 0169
		static Delegate GetGetRecoverMinutesHandler ()
		{
			if (cb_getRecoverMinutes == null)
				cb_getRecoverMinutes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecoverMinutes);
			return cb_getRecoverMinutes;
		}

		static int n_GetRecoverMinutes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecoverMinutes;
		}
#pragma warning restore 0169

		static Delegate cb_setRecoverMinutes_I;
#pragma warning disable 0169
		static Delegate GetSetRecoverMinutes_IHandler ()
		{
			if (cb_setRecoverMinutes_I == null)
				cb_setRecoverMinutes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecoverMinutes_I);
			return cb_setRecoverMinutes_I;
		}

		static void n_SetRecoverMinutes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecoverMinutes = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RecoverMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getRecoverMinutes' and count(parameter)=0]"
			[Register ("getRecoverMinutes", "()I", "GetGetRecoverMinutesHandler")]
			get {
				const string __id = "getRecoverMinutes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setRecoverMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecoverMinutes", "(I)V", "GetSetRecoverMinutes_IHandler")]
			set {
				const string __id = "setRecoverMinutes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSleepDuration;
#pragma warning disable 0169
		static Delegate GetGetSleepDurationHandler ()
		{
			if (cb_getSleepDuration == null)
				cb_getSleepDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetSleepDuration);
			return cb_getSleepDuration;
		}

		static double n_GetSleepDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepDuration_D;
#pragma warning disable 0169
		static Delegate GetSetSleepDuration_DHandler ()
		{
			if (cb_setSleepDuration_D == null)
				cb_setSleepDuration_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetSleepDuration_D);
			return cb_setSleepDuration_D;
		}

		static void n_SetSleepDuration_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepDuration = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double SleepDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getSleepDuration' and count(parameter)=0]"
			[Register ("getSleepDuration", "()D", "GetGetSleepDurationHandler")]
			get {
				const string __id = "getSleepDuration.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setSleepDuration' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setSleepDuration", "(D)V", "GetSetSleepDuration_DHandler")]
			set {
				const string __id = "setSleepDuration.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSleepRecover;
#pragma warning disable 0169
		static Delegate GetGetSleepRecoverHandler ()
		{
			if (cb_getSleepRecover == null)
				cb_getSleepRecover = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetSleepRecover);
			return cb_getSleepRecover;
		}

		static double n_GetSleepRecover (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SleepRecover;
		}
#pragma warning restore 0169

		static Delegate cb_setSleepRecover_D;
#pragma warning disable 0169
		static Delegate GetSetSleepRecover_DHandler ()
		{
			if (cb_setSleepRecover_D == null)
				cb_setSleepRecover_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetSleepRecover_D);
			return cb_setSleepRecover_D;
		}

		static void n_SetSleepRecover_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SleepRecover = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double SleepRecover {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getSleepRecover' and count(parameter)=0]"
			[Register ("getSleepRecover", "()D", "GetGetSleepRecoverHandler")]
			get {
				const string __id = "getSleepRecover.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setSleepRecover' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setSleepRecover", "(D)V", "GetSetSleepRecover_DHandler")]
			set {
				const string __id = "setSleepRecover.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStressMinutes;
#pragma warning disable 0169
		static Delegate GetGetStressMinutesHandler ()
		{
			if (cb_getStressMinutes == null)
				cb_getStressMinutes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStressMinutes);
			return cb_getStressMinutes;
		}

		static int n_GetStressMinutes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StressMinutes;
		}
#pragma warning restore 0169

		static Delegate cb_setStressMinutes_I;
#pragma warning disable 0169
		static Delegate GetSetStressMinutes_IHandler ()
		{
			if (cb_setStressMinutes_I == null)
				cb_setStressMinutes_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStressMinutes_I);
			return cb_setStressMinutes_I;
		}

		static void n_SetStressMinutes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.Event.WellnessDailyStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StressMinutes = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int StressMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='getStressMinutes' and count(parameter)=0]"
			[Register ("getStressMinutes", "()I", "GetGetStressMinutesHandler")]
			get {
				const string __id = "getStressMinutes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model.event']/class[@name='WellnessDailyStats']/method[@name='setStressMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStressMinutes", "(I)V", "GetSetStressMinutes_IHandler")]
			set {
				const string __id = "setStressMinutes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
