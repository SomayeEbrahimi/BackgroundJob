using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Dataparser.Vv330 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330", DoNotGenerateAcw=true)]
	public partial class ReceiveDataParser_VV330 : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/field[@name='d']"
		[Register ("d")]
		public global::Com.Vivalnk.Sdk.IDataReceiveListener D {
			get {
				const string __id = "d.Lcom/vivalnk/sdk/DataReceiveListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.IDataReceiveListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Lcom/vivalnk/sdk/DataReceiveListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330.DataFeedEvent']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330$DataFeedEvent", DoNotGenerateAcw=true)]
		public partial class DataFeedEvent : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330.DataFeedEvent']/field[@name='device']"
			[Register ("device")]
			public global::Com.Vivalnk.Sdk.Model.Device Device {
				get {
					const string __id = "device.Lcom/vivalnk/sdk/model/Device;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "device.Lcom/vivalnk/sdk/model/Device;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330.DataFeedEvent']/field[@name='sampleData']"
			[Register ("sampleData")]
			public global::Com.Vivalnk.Sdk.Model.SampleData SampleData {
				get {
					const string __id = "sampleData.Lcom/vivalnk/sdk/model/SampleData;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sampleData.Lcom/vivalnk/sdk/model/SampleData;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330$DataFeedEvent", typeof (DataFeedEvent));
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

			protected DataFeedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330.DataFeedEvent']/constructor[@name='ReceiveDataParser_VV330.DataFeedEvent' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DataFeedEvent ()
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330", typeof (ReceiveDataParser_VV330));
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

		protected ReceiveDataParser_VV330 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/constructor[@name='ReceiveDataParser_VV330' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.DataReceiveListener']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;)V", "")]
		public unsafe ReceiveDataParser_VV330 (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.IDataReceiveListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/DataReceiveListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_a_Z;
#pragma warning disable 0169
		static Delegate GetA_ZHandler ()
		{
			if (cb_a_Z == null)
				cb_a_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_A_Z);
			return cb_a_Z;
		}

		static void n_A_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "GetA_ZHandler")]
		public virtual unsafe void A (bool p0)
		{
			const string __id = "a.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_BBarrayB;
#pragma warning disable 0169
		static Delegate GetA_BBarrayBHandler ()
		{
			if (cb_a_BBarrayB == null)
				cb_a_BBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPBBL_L) n_A_BBarrayB);
			return cb_a_BBarrayB;
		}

		static IntPtr n_A_BBarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, sbyte p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("a", "(BB[B)Lcom/vivalnk/sdk/model/BatteryInfo;", "GetA_BBarrayBHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Model.BatteryInfo A (sbyte p0, sbyte p1, byte[] p2)
		{
			const string __id = "a.(BB[B)Lcom/vivalnk/sdk/model/BatteryInfo;";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.BatteryInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_a_arrayB;
#pragma warning disable 0169
		static Delegate GetA_arrayBHandler ()
		{
			if (cb_a_arrayB == null)
				cb_a_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_arrayB);
			return cb_a_arrayB;
		}

		static void n_A_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.A (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)V", "GetA_arrayBHandler")]
		public virtual unsafe void A (byte[] p0)
		{
			const string __id = "a.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='boolean']]"
		[Register ("a", "(Lcom/vivalnk/sdk/model/Device;Z)V", "")]
		public static unsafe void A (global::Com.Vivalnk.Sdk.Model.Device p0, bool p1)
		{
			const string __id = "a.(Lcom/vivalnk/sdk/model/Device;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_vivalnk_sdk_model_Person_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_vivalnk_sdk_model_Person_Handler ()
		{
			if (cb_a_Lcom_vivalnk_sdk_model_Person_ == null)
				cb_a_Lcom_vivalnk_sdk_model_Person_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_A_Lcom_vivalnk_sdk_model_Person_);
			return cb_a_Lcom_vivalnk_sdk_model_Person_;
		}

		static void n_A_Lcom_vivalnk_sdk_model_Person_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Person> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Person']]"
		[Register ("a", "(Lcom/vivalnk/sdk/model/Person;)V", "GetA_Lcom_vivalnk_sdk_model_Person_Handler")]
		public virtual unsafe void A (global::Com.Vivalnk.Sdk.Model.Person p0)
		{
			const string __id = "a.(Lcom/vivalnk/sdk/model/Person;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_J;
#pragma warning disable 0169
		static Delegate GetA_JHandler ()
		{
			if (cb_a_J == null)
				cb_a_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_A_J);
			return cb_a_J;
		}

		static void n_A_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='a' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("a", "(J)V", "GetA_JHandler")]
		public virtual unsafe void A (long p0)
		{
			const string __id = "a.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_b_arrayB;
#pragma warning disable 0169
		static Delegate GetB_arrayBHandler ()
		{
			if (cb_b_arrayB == null)
				cb_b_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_B_arrayB);
			return cb_b_arrayB;
		}

		static void n_B_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.B (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='b' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("b", "([B)V", "GetB_arrayBHandler")]
		public virtual unsafe void B (byte[] p0)
		{
			const string __id = "b.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_C);
			return cb_c;
		}

		static void n_C (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "GetCHandler")]
		public virtual unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_c_arrayB;
#pragma warning disable 0169
		static Delegate GetC_arrayBHandler ()
		{
			if (cb_c_arrayB == null)
				cb_c_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_C_arrayB);
			return cb_c_arrayB;
		}

		static bool n_C_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.C (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='c' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("c", "([B)Z", "GetC_arrayBHandler")]
		public virtual unsafe bool C (byte[] p0)
		{
			const string __id = "c.([B)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_;
#pragma warning disable 0169
		static Delegate GetOnDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_Handler ()
		{
			if (cb_onDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_ == null)
				cb_onDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_);
			return cb_onDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_;
		}

		static void n_OnDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330.DataFeedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDataFeedEvent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.dataparser.vv330']/class[@name='ReceiveDataParser_VV330']/method[@name='onDataFeedEvent' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.dataparser.vv330.ReceiveDataParser_VV330.DataFeedEvent']]"
		[Register ("onDataFeedEvent", "(Lcom/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330$DataFeedEvent;)V", "GetOnDataFeedEvent_Lcom_vivalnk_sdk_dataparser_vv330_ReceiveDataParser_VV330_DataFeedEvent_Handler")]
		public virtual unsafe void OnDataFeedEvent (global::Com.Vivalnk.Sdk.Dataparser.Vv330.ReceiveDataParser_VV330.DataFeedEvent p0)
		{
			const string __id = "onDataFeedEvent.(Lcom/vivalnk/sdk/dataparser/vv330/ReceiveDataParser_VV330$DataFeedEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
