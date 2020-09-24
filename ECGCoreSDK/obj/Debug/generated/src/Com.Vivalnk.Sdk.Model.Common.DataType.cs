using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Model.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/model/common/DataType", DoNotGenerateAcw=true)]
	public partial class DataType : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']/field[@name='sDataTypeMap']"
		[Register ("sDataTypeMap")]
		public static global::System.Collections.IDictionary SDataTypeMap {
			get {
				const string __id = "sDataTypeMap.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sDataTypeMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		[Register ("com/vivalnk/sdk/model/common/DataType$DataKey", DoNotGenerateAcw=true)]
		public abstract class DataKey : Java.Lang.Object {

			internal DataKey ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='BP']"
			[Register ("BP")]
			public const string Bp = (string) "BP";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='HR']"
			[Register ("HR")]
			public const string Hr = (string) "HR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='RR']"
			[Register ("RR")]
			public const string Rr = (string) "RR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='acc']"
			[Register ("acc")]
			public const string Acc = (string) "acc";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='accAccuracy']"
			[Register ("accAccuracy")]
			public const string AccAccuracy = (string) "accAccuracy";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='accFrequency']"
			[Register ("accFrequency")]
			public const string AccFrequency = (string) "accFrequency";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='activity']"
			[Register ("activity")]
			public const string Activity = (string) "activity";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='avRR']"
			[Register ("avRR")]
			public const string AvRR = (string) "avRR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='deviceInfo']"
			[Register ("deviceInfo")]
			public const string DeviceInfo = (string) "deviceInfo";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='ecg']"
			[Register ("ecg")]
			public const string Ecg = (string) "ecg";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='ecgFrequency']"
			[Register ("ecgFrequency")]
			public const string EcgFrequency = (string) "ecgFrequency";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='ecgMV']"
			[Register ("ecgMV")]
			public const string EcgMV = (string) "ecgMV";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='eteResult']"
			[Register ("eteResult")]
			public const string EteResult = (string) "eteResult";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='flash']"
			[Register ("flash")]
			public const string Flash = (string) "flash";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='fwVer']"
			[Register ("fwVer")]
			public const string FwVer = (string) "fwVer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='hwVer']"
			[Register ("hwVer")]
			public const string HwVer = (string) "hwVer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='leadOn']"
			[Register ("leadOn")]
			public const string LeadOn = (string) "leadOn";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='magnification']"
			[Register ("magnification")]
			public const string Magnification = (string) "magnification";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='protocol']"
			[Register ("protocol")]
			public const string Protocol = (string) "protocol";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='receiveTime']"
			[Register ("receiveTime")]
			public const string ReceiveTime = (string) "receiveTime";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='rri']"
			[Register ("rri")]
			public const string Rri = (string) "rri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='rwl']"
			[Register ("rwl")]
			public const string Rwl = (string) "rwl";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='temperature']"
			[Register ("temperature")]
			public const string Temperature = (string) "temperature";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/interface[@name='DataType.DataKey']/field[@name='time']"
			[Register ("time")]
			public const string Time = (string) "time";
		}

		[Register ("com/vivalnk/sdk/model/common/DataType$DataKey", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'DataKey' type. This type will be removed in a future release.", error: true)]
		public abstract class DataKeyConsts : DataKey {

			private DataKeyConsts ()
			{
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/model/common/DataType", typeof (DataType));
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

		protected DataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']/constructor[@name='DataType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataType ()
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

		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Class> DataTypeMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']/method[@name='getDataTypeMap' and count(parameter)=0]"
			[Register ("getDataTypeMap", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getDataTypeMap.()Ljava/util/Map;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Class>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']/method[@name='setDataTypeMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Class&gt;']]"
			[Register ("setDataTypeMap", "(Ljava/util/Map;)V", "")]
			set {
				const string __id = "setDataTypeMap.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Class>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.model.common']/class[@name='DataType']/method[@name='getDataType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDataType", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetDataType (string p0)
		{
			const string __id = "getDataType.(Ljava/lang/String;)Ljava/lang/Class;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
