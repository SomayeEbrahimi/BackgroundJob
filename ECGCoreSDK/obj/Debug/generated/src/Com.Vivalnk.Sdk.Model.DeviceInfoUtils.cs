using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/DeviceInfoUtils", DoNotGenerateAcw=true)]
	public partial class DeviceInfoUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/DeviceInfoUtils", typeof (DeviceInfoUtils));
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

		protected DeviceInfoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/constructor[@name='DeviceInfoUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceInfoUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getAccSamplingAccuracy' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAccSamplingAccuracy", "(Ljava/util/Map;)I", "")]
		public static unsafe int GetAccSamplingAccuracy (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getAccSamplingAccuracy.(Ljava/util/Map;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getAccSamplingFrequency' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAccSamplingFrequency", "(Ljava/util/Map;)I", "")]
		public static unsafe int GetAccSamplingFrequency (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getAccSamplingFrequency.(Ljava/util/Map;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getMagnification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getMagnification", "(Ljava/util/Map;)I", "")]
		public static unsafe int GetMagnification (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getMagnification.(Ljava/util/Map;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getManufacturer' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getManufacturer", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetManufacturer (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getManufacturer.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getModel' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getModel", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetModel (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getModel.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='getSamplingFrequency' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getSamplingFrequency", "(Ljava/util/Map;)I", "")]
		public static unsafe int GetSamplingFrequency (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "getSamplingFrequency.(Ljava/util/Map;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='hasHR' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("hasHR", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool HasHR (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "hasHR.(Ljava/util/Map;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceInfoUtils']/method[@name='isEncryption' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("isEncryption", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool IsEncryption (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "isEncryption.(Ljava/util/Map;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
