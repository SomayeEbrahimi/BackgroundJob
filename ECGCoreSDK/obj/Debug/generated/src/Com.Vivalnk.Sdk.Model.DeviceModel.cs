using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/DeviceModel", DoNotGenerateAcw=true)]
	public sealed partial class DeviceModel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Unknown {
			get {
				const string __id = "Unknown.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VV200']"
		[Register ("VV200")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vv200 {
			get {
				const string __id = "VV200.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VV310']"
		[Register ("VV310")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vv310 {
			get {
				const string __id = "VV310.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VV310_1']"
		[Register ("VV310_1")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vv3101 {
			get {
				const string __id = "VV310_1.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VV330']"
		[Register ("VV330")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vv330 {
			get {
				const string __id = "VV330.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VV340']"
		[Register ("VV340")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vv340 {
			get {
				const string __id = "VV340.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='VVBP']"
		[Register ("VVBP")]
		public static global::Com.Vivalnk.Sdk.Model.DeviceModel Vvbp {
			get {
				const string __id = "VVBP.Lcom/vivalnk/sdk/model/DeviceModel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/field[@name='value']"
		[Register ("value")]
		public int Value {
			get {
				const string __id = "value.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "value.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/DeviceModel", typeof (DeviceModel));
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

		internal DeviceModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/constructor[@name='DeviceModel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe DeviceModel (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/vivalnk/sdk/model/DeviceModel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel ValueOf (int p0)
		{
			const string __id = "valueOf.(I)Lcom/vivalnk/sdk/model/DeviceModel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/model/DeviceModel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/model/DeviceModel;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.DeviceModel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model']/class[@name='DeviceModel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/model/DeviceModel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Model.DeviceModel[] Values ()
		{
			const string __id = "values.()[Lcom/vivalnk/sdk/model/DeviceModel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Vivalnk.Sdk.Model.DeviceModel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Model.DeviceModel));
			} finally {
			}
		}

	}
}
