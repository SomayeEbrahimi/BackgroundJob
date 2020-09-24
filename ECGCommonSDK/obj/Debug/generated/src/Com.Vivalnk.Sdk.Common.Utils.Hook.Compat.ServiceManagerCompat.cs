using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Compat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/compat/ServiceManagerCompat", DoNotGenerateAcw=true)]
	public partial class ServiceManagerCompat : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/hook/compat/ServiceManagerCompat", typeof (ServiceManagerCompat));
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

		protected ServiceManagerCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/constructor[@name='ServiceManagerCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceManagerCompat ()
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

		public static unsafe global::Java.Lang.Reflect.Field CacheField {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getCacheField' and count(parameter)=0]"
			[Register ("getCacheField", "()Ljava/lang/reflect/Field;", "")]
			get {
				const string __id = "getCacheField.()Ljava/lang/reflect/Field;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Android.OS.IBinder> CacheValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getCacheValue' and count(parameter)=0]"
			[Register ("getCacheValue", "()Ljava/util/HashMap;", "")]
			get {
				const string __id = "getCacheValue.()Ljava/util/HashMap;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaDictionary<string, global::Android.OS.IBinder>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Reflect.Method Service {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getService' and count(parameter)=0]"
			[Register ("getService", "()Ljava/lang/reflect/Method;", "")]
			get {
				const string __id = "getService.()Ljava/lang/reflect/Method;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Java.Lang.Class ServiceManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getServiceManager' and count(parameter)=0]"
			[Register ("getServiceManager", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getServiceManager.()Ljava/lang/Class;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
