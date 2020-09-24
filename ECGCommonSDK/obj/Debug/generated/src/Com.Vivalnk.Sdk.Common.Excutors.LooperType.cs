using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/LooperType", DoNotGenerateAcw=true)]
	public sealed partial class LooperType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='COMMAND']"
		[Register ("COMMAND")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Command {
			get {
				const string __id = "COMMAND.Lcom/vivalnk/sdk/common/excutors/LooperType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='DATA']"
		[Register ("DATA")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Data {
			get {
				const string __id = "DATA.Lcom/vivalnk/sdk/common/excutors/LooperType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='IO']"
		[Register ("IO")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Io {
			get {
				const string __id = "IO.Lcom/vivalnk/sdk/common/excutors/LooperType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/field[@name='LOG']"
		[Register ("LOG")]
		public static global::Com.Vivalnk.Sdk.Common.Excutors.LooperType Log {
			get {
				const string __id = "LOG.Lcom/vivalnk/sdk/common/excutors/LooperType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/excutors/LooperType", typeof (LooperType));
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

		internal LooperType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/excutors/LooperType;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Excutors.LooperType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/common/excutors/LooperType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Excutors.LooperType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='LooperType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/excutors/LooperType;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Excutors.LooperType[] Values ()
		{
			const string __id = "values.()[Lcom/vivalnk/sdk/common/excutors/LooperType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Excutors.LooperType));
			} finally {
			}
		}

	}
}
