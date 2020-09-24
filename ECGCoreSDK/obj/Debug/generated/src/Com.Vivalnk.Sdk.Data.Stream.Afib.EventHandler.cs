using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Data.Stream.Afib {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/data/stream/afib/EventHandler", DoNotGenerateAcw=true)]
	public partial class EventHandler : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='afib_ranger_out']"
		[Register ("afib_ranger_out")]
		public static string AfibRangerOut {
			get {
				const string __id = "afib_ranger_out.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "afib_ranger_out.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='afib_small_data']"
		[Register ("afib_small_data")]
		public static string AfibSmallData {
			get {
				const string __id = "afib_small_data.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "afib_small_data.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='flash']"
		[Register ("flash")]
		public bool Flash {
			get {
				const string __id = "flash.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "flash.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='logFilePath']"
		[Register ("logFilePath")]
		public static string LogFilePath {
			get {
				const string __id = "logFilePath.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logFilePath.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='logFilePathFlash']"
		[Register ("logFilePathFlash")]
		public static string LogFilePathFlash {
			get {
				const string __id = "logFilePathFlash.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logFilePathFlash.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='pause_ranger_out']"
		[Register ("pause_ranger_out")]
		public static string PauseRangerOut {
			get {
				const string __id = "pause_ranger_out.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pause_ranger_out.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='pause_small_data']"
		[Register ("pause_small_data")]
		public static string PauseSmallData {
			get {
				const string __id = "pause_small_data.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pause_small_data.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/field[@name='sLoggable']"
		[Register ("sLoggable")]
		public static bool SLoggable {
			get {
				const string __id = "sLoggable.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "sLoggable.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/stream/afib/EventHandler", typeof (EventHandler));
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

		protected EventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/constructor[@name='EventHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventHandler ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/constructor[@name='EventHandler' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe EventHandler (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetAddDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_Handler ()
		{
			if (cb_addDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_ == null)
				cb_addDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_);
			return cb_addDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_;
		}

		static IntPtr n_AddDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.Stream.Afib.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.Event>.ToLocalJniHandle (__this.AddDataList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='addDataList' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='java.util.ArrayList&lt;com.vivalnk.sdk.model.SampleData&gt;']]"
		[Register ("addDataList", "(Lcom/vivalnk/sdk/model/Device;Ljava/util/ArrayList;)Ljava/util/List;", "GetAddDataList_Lcom_vivalnk_sdk_model_Device_Ljava_util_ArrayList_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.Event> AddDataList (global::Com.Vivalnk.Sdk.Model.Device p0, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p1)
		{
			const string __id = "addDataList.(Lcom/vivalnk/sdk/model/Device;Ljava/util/ArrayList;)Ljava/util/List;";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.Event>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_;
#pragma warning disable 0169
		static Delegate GetAddEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_Handler ()
		{
			if (cb_addEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_ == null)
				cb_addEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AddEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_);
			return cb_addEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_;
		}

		static IntPtr n_AddEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.Stream.Afib.EventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Vivalnk.Sdk.IDataReceiveListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.IDataReceiveListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddEventData (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='addEventData' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.model.SampleData'] and parameter[3][@type='com.vivalnk.sdk.DataReceiveListener']]"
		[Register ("addEventData", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/model/SampleData;Lcom/vivalnk/sdk/DataReceiveListener;)Lcom/vivalnk/sdk/model/Event;", "GetAddEventData_Lcom_vivalnk_sdk_model_Device_Lcom_vivalnk_sdk_model_SampleData_Lcom_vivalnk_sdk_DataReceiveListener_Handler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Event AddEventData (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.Model.SampleData p1, global::Com.Vivalnk.Sdk.IDataReceiveListener p2)
		{
			const string __id = "addEventData.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/model/SampleData;Lcom/vivalnk/sdk/DataReceiveListener;)Lcom/vivalnk/sdk/model/Event;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Copy (string p0)
		{
			const string __id = "copy.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='detectAfib' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("detectAfib", "([I)[I", "")]
		public static unsafe int[] DetectAfib (int[] p0)
		{
			const string __id = "detectAfib.([I)[I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='getEvent' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.model.Event.EventType'] and parameter[3][@type='java.util.ArrayList&lt;com.vivalnk.sdk.model.SampleData&gt;'] and parameter[4][@type='boolean']]"
		[Register ("getEvent", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/model/Event$EventType;Ljava/util/ArrayList;Z)Lcom/vivalnk/sdk/model/Event;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.Event GetEvent (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.Model.Event.EventType p1, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p2, bool p3)
		{
			const string __id = "getEvent.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/model/Event$EventType;Ljava/util/ArrayList;Z)Lcom/vivalnk/sdk/model/Event;";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='handlePauseEvent' and count(parameter)=5 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.DataReceiveListener'] and parameter[3][@type='java.util.ArrayList&lt;com.vivalnk.sdk.model.SampleData&gt;'] and parameter[4][@type='double[]'] and parameter[5][@type='boolean']]"
		[Register ("handlePauseEvent", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;Ljava/util/ArrayList;[DZ)Lcom/vivalnk/sdk/model/Event;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.Event HandlePauseEvent (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.IDataReceiveListener p1, global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p2, double[] p3, bool p4)
		{
			const string __id = "handlePauseEvent.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;Ljava/util/ArrayList;[DZ)Lcom/vivalnk/sdk/model/Event;";
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Event> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='isPauseValid' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.model.SampleData&gt;']]"
		[Register ("isPauseValid", "(Ljava/util/List;)Z", "")]
		public static unsafe bool IsPauseValid (global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p0)
		{
			const string __id = "isPauseValid.(Ljava/util/List;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("log", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void Log (string p0, bool p1)
		{
			const string __id = "log.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='publishEvent' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.DataReceiveListener'] and parameter[3][@type='com.vivalnk.sdk.model.Event']]"
		[Register ("publishEvent", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;Lcom/vivalnk/sdk/model/Event;)V", "")]
		public static unsafe void PublishEvent (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.IDataReceiveListener p1, global::Com.Vivalnk.Sdk.Model.Event p2)
		{
			const string __id = "publishEvent.(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;Lcom/vivalnk/sdk/model/Event;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='setLoggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoggable", "(Z)V", "")]
		public static unsafe void SetLoggable (bool p0)
		{
			const string __id = "setLoggable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.afib']/class[@name='EventHandler']/method[@name='setStartCondition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setStartCondition", "(II)V", "")]
		public static unsafe void SetStartCondition (int p0, int p1)
		{
			const string __id = "setStartCondition.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
