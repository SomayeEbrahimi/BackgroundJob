using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/utils/FieldUtils", DoNotGenerateAcw=true)]
	public partial class FieldUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/hook/utils/FieldUtils", typeof (FieldUtils));
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

		protected FieldUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']/constructor[@name='FieldUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FieldUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.utils']/class[@name='FieldUtils']/method[@name='getDeclaredField' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getDeclaredField", "(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetDeclaredField (global::Java.Lang.Class cls, string fieldName, bool forceAccess)
		{
			const string __id = "getDeclaredField.(Ljava/lang/Class;Ljava/lang/String;Z)Ljava/lang/reflect/Field;";
			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [1] = new JniArgumentValue (native_fieldName);
				__args [2] = new JniArgumentValue (forceAccess);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

	}
}
