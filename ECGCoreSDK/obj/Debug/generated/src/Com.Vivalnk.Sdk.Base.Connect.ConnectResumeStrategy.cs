using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Base.Connect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/base/connect/ConnectResumeStrategy", DoNotGenerateAcw=true)]
	public partial class ConnectResumeStrategy : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/base/connect/ConnectResumeStrategy", typeof (ConnectResumeStrategy));
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

		protected ConnectResumeStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/constructor[@name='ConnectResumeStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectResumeStrategy ()
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

		static Delegate cb_getCacheSize;
#pragma warning disable 0169
		static Delegate GetGetCacheSizeHandler ()
		{
			if (cb_getCacheSize == null)
				cb_getCacheSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCacheSize);
			return cb_getCacheSize;
		}

		static int n_GetCacheSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheSize;
		}
#pragma warning restore 0169

		static Delegate cb_setCacheSize_I;
#pragma warning disable 0169
		static Delegate GetSetCacheSize_IHandler ()
		{
			if (cb_setCacheSize_I == null)
				cb_setCacheSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCacheSize_I);
			return cb_setCacheSize_I;
		}

		static void n_SetCacheSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CacheSize = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='getCacheSize' and count(parameter)=0]"
			[Register ("getCacheSize", "()I", "GetGetCacheSizeHandler")]
			get {
				const string __id = "getCacheSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='setCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCacheSize", "(I)V", "GetSetCacheSize_IHandler")]
			set {
				const string __id = "setCacheSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDataReceiveTimeOut;
#pragma warning disable 0169
		static Delegate GetGetDataReceiveTimeOutHandler ()
		{
			if (cb_getDataReceiveTimeOut == null)
				cb_getDataReceiveTimeOut = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDataReceiveTimeOut);
			return cb_getDataReceiveTimeOut;
		}

		static long n_GetDataReceiveTimeOut (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataReceiveTimeOut;
		}
#pragma warning restore 0169

		static Delegate cb_setDataReceiveTimeOut_J;
#pragma warning disable 0169
		static Delegate GetSetDataReceiveTimeOut_JHandler ()
		{
			if (cb_setDataReceiveTimeOut_J == null)
				cb_setDataReceiveTimeOut_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetDataReceiveTimeOut_J);
			return cb_setDataReceiveTimeOut_J;
		}

		static void n_SetDataReceiveTimeOut_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DataReceiveTimeOut = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long DataReceiveTimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='getDataReceiveTimeOut' and count(parameter)=0]"
			[Register ("getDataReceiveTimeOut", "()J", "GetGetDataReceiveTimeOutHandler")]
			get {
				const string __id = "getDataReceiveTimeOut.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='setDataReceiveTimeOut' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDataReceiveTimeOut", "(J)V", "GetSetDataReceiveTimeOut_JHandler")]
			set {
				const string __id = "setDataReceiveTimeOut.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryGapTime;
#pragma warning disable 0169
		static Delegate GetGetRetryGapTimeHandler ()
		{
			if (cb_getRetryGapTime == null)
				cb_getRetryGapTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRetryGapTime);
			return cb_getRetryGapTime;
		}

		static long n_GetRetryGapTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryGapTime;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryGapTime_J;
#pragma warning disable 0169
		static Delegate GetSetRetryGapTime_JHandler ()
		{
			if (cb_setRetryGapTime_J == null)
				cb_setRetryGapTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetRetryGapTime_J);
			return cb_setRetryGapTime_J;
		}

		static void n_SetRetryGapTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryGapTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long RetryGapTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='getRetryGapTime' and count(parameter)=0]"
			[Register ("getRetryGapTime", "()J", "GetGetRetryGapTimeHandler")]
			get {
				const string __id = "getRetryGapTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='setRetryGapTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRetryGapTime", "(J)V", "GetSetRetryGapTime_JHandler")]
			set {
				const string __id = "setRetryGapTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryScanTimeOout;
#pragma warning disable 0169
		static Delegate GetGetRetryScanTimeOoutHandler ()
		{
			if (cb_getRetryScanTimeOout == null)
				cb_getRetryScanTimeOout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRetryScanTimeOout);
			return cb_getRetryScanTimeOout;
		}

		static long n_GetRetryScanTimeOout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryScanTimeOout;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryScanTimeOout_J;
#pragma warning disable 0169
		static Delegate GetSetRetryScanTimeOout_JHandler ()
		{
			if (cb_setRetryScanTimeOout_J == null)
				cb_setRetryScanTimeOout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetRetryScanTimeOout_J);
			return cb_setRetryScanTimeOout_J;
		}

		static void n_SetRetryScanTimeOout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryScanTimeOout = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long RetryScanTimeOout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='getRetryScanTimeOout' and count(parameter)=0]"
			[Register ("getRetryScanTimeOout", "()J", "GetGetRetryScanTimeOoutHandler")]
			get {
				const string __id = "getRetryScanTimeOout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='setRetryScanTimeOout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRetryScanTimeOout", "(J)V", "GetSetRetryScanTimeOout_JHandler")]
			set {
				const string __id = "setRetryScanTimeOout.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryTotalCount;
#pragma warning disable 0169
		static Delegate GetGetRetryTotalCountHandler ()
		{
			if (cb_getRetryTotalCount == null)
				cb_getRetryTotalCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetRetryTotalCount);
			return cb_getRetryTotalCount;
		}

		static long n_GetRetryTotalCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryTotalCount;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryTotalCount_J;
#pragma warning disable 0169
		static Delegate GetSetRetryTotalCount_JHandler ()
		{
			if (cb_setRetryTotalCount_J == null)
				cb_setRetryTotalCount_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetRetryTotalCount_J);
			return cb_setRetryTotalCount_J;
		}

		static void n_SetRetryTotalCount_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryTotalCount = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long RetryTotalCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='getRetryTotalCount' and count(parameter)=0]"
			[Register ("getRetryTotalCount", "()J", "GetGetRetryTotalCountHandler")]
			get {
				const string __id = "getRetryTotalCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='setRetryTotalCount' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRetryTotalCount", "(J)V", "GetSetRetryTotalCount_JHandler")]
			set {
				const string __id = "setRetryTotalCount.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_intercept;
#pragma warning disable 0169
		static Delegate GetInterceptHandler ()
		{
			if (cb_intercept == null)
				cb_intercept = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Intercept);
			return cb_intercept;
		}

		static bool n_Intercept (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.Connect.ConnectResumeStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Intercept ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base.connect']/class[@name='ConnectResumeStrategy']/method[@name='intercept' and count(parameter)=0]"
		[Register ("intercept", "()Z", "GetInterceptHandler")]
		public virtual unsafe bool Intercept ()
		{
			const string __id = "intercept.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
