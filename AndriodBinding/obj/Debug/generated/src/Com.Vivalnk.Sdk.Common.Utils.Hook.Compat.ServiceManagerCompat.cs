using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook.Compat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/compat/ServiceManagerCompat", DoNotGenerateAcw=true)]
	public partial class ServiceManagerCompat : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/compat/ServiceManagerCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceManagerCompat); }
		}

		protected ServiceManagerCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/constructor[@name='ServiceManagerCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceManagerCompat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ServiceManagerCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getCacheField;
		public static unsafe global::Java.Lang.Reflect.Field CacheField {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getCacheField' and count(parameter)=0]"
			[Register ("getCacheField", "()Ljava/lang/reflect/Field;", "")]
			get {
				if (id_getCacheField == IntPtr.Zero)
					id_getCacheField = JNIEnv.GetStaticMethodID (class_ref, "getCacheField", "()Ljava/lang/reflect/Field;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCacheField), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCacheValue;
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Android.OS.IBinder> CacheValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getCacheValue' and count(parameter)=0]"
			[Register ("getCacheValue", "()Ljava/util/HashMap;", "")]
			get {
				if (id_getCacheValue == IntPtr.Zero)
					id_getCacheValue = JNIEnv.GetStaticMethodID (class_ref, "getCacheValue", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<string, global::Android.OS.IBinder>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCacheValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getService;
		public static unsafe global::Java.Lang.Reflect.Method Service {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getService' and count(parameter)=0]"
			[Register ("getService", "()Ljava/lang/reflect/Method;", "")]
			get {
				if (id_getService == IntPtr.Zero)
					id_getService = JNIEnv.GetStaticMethodID (class_ref, "getService", "()Ljava/lang/reflect/Method;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getService), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceManager;
		public static unsafe global::Java.Lang.Class ServiceManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook.compat']/class[@name='ServiceManagerCompat']/method[@name='getServiceManager' and count(parameter)=0]"
			[Register ("getServiceManager", "()Ljava/lang/Class;", "")]
			get {
				if (id_getServiceManager == IntPtr.Zero)
					id_getServiceManager = JNIEnv.GetStaticMethodID (class_ref, "getServiceManager", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getServiceManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
