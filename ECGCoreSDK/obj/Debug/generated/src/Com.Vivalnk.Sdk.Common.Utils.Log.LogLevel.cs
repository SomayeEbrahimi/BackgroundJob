using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/log/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel All {
			get {
				const string __id = "ALL.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ASSERT']"
		[Register ("ASSERT")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Assert {
			get {
				const string __id = "ASSERT.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Debug {
			get {
				const string __id = "DEBUG.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Error {
			get {
				const string __id = "ERROR.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Info {
			get {
				const string __id = "INFO.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='INTERNAL']"
		[Register ("INTERNAL")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Internal {
			get {
				const string __id = "INTERNAL.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='NOTHING']"
		[Register ("NOTHING")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Nothing {
			get {
				const string __id = "NOTHING.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Verbose {
			get {
				const string __id = "VERBOSE.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/field[@name='WARN']"
		[Register ("WARN")]
		public static global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel Warn {
			get {
				const string __id = "WARN.Lcom/vivalnk/sdk/common/utils/log/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/log/LogLevel", typeof (LogLevel));
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

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "")]
		public unsafe int Value ()
		{
			const string __id = "value.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel ValueOf (int level)
		{
			const string __id = "valueOf.(I)Lcom/vivalnk/sdk/common/utils/log/LogLevel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/vivalnk/sdk/common/utils/log/LogLevel;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.log']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/vivalnk/sdk/common/utils/log/LogLevel;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel[] Values ()
		{
			const string __id = "values.()[Lcom/vivalnk/sdk/common/utils/log/LogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Vivalnk.Sdk.Common.Utils.Log.LogLevel));
			} finally {
			}
		}

	}
}
