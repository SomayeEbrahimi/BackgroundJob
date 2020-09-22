using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectPool']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ObjectPool", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ObjectPool : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.utils']/interface[@name='ObjectPool.PoolObjectFactory']"
		[Register ("com/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory", "", "Com.Vivalnk.Sdk.Utils.ObjectPool/IPoolObjectFactoryInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IPoolObjectFactory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/interface[@name='ObjectPool.PoolObjectFactory']/method[@name='createObject' and count(parameter)=0]"
			[Register ("createObject", "()Ljava/lang/Object;", "GetCreateObjectHandler:Com.Vivalnk.Sdk.Utils.ObjectPool/IPoolObjectFactoryInvoker, AndriodBinding")]
			global::Java.Lang.Object CreateObject ();

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory", DoNotGenerateAcw=true)]
		internal partial class IPoolObjectFactoryInvoker : global::Java.Lang.Object, IPoolObjectFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPoolObjectFactoryInvoker); }
			}

			IntPtr class_ref;

			public static IPoolObjectFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPoolObjectFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.utils.ObjectPool.PoolObjectFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPoolObjectFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_createObject;
#pragma warning disable 0169
			static Delegate GetCreateObjectHandler ()
			{
				if (cb_createObject == null)
					cb_createObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CreateObject);
				return cb_createObject;
			}

			static IntPtr n_CreateObject (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ObjectPool.IPoolObjectFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreateObject ());
			}
#pragma warning restore 0169

			IntPtr id_createObject;
			public unsafe global::Java.Lang.Object CreateObject ()
			{
				if (id_createObject == IntPtr.Zero)
					id_createObject = JNIEnv.GetMethodID (class_ref, "createObject", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createObject), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/ObjectPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectPool); }
		}

		protected ObjectPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_vivalnk_sdk_utils_ObjectPool_PoolObjectFactory_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectPool']/constructor[@name='ObjectPool' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.utils.ObjectPool.PoolObjectFactory&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory;I)V", "")]
		public unsafe ObjectPool (global::Com.Vivalnk.Sdk.Utils.ObjectPool.IPoolObjectFactory factory, int maxSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (factory);
				__args [1] = new JValue (maxSize);
				if (((object) this).GetType () != typeof (ObjectPool)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_vivalnk_sdk_utils_ObjectPool_PoolObjectFactory_I == IntPtr.Zero)
					id_ctor_Lcom_vivalnk_sdk_utils_ObjectPool_PoolObjectFactory_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/vivalnk/sdk/utils/ObjectPool$PoolObjectFactory;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_vivalnk_sdk_utils_ObjectPool_PoolObjectFactory_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_vivalnk_sdk_utils_ObjectPool_PoolObjectFactory_I, __args);
			} finally {
			}
		}

		static Delegate cb_free_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFree_Ljava_lang_Object_Handler ()
		{
			if (cb_free_Ljava_lang_Object_ == null)
				cb_free_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Free_Ljava_lang_Object_);
			return cb_free_Ljava_lang_Object_;
		}

		static void n_Free_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.Free (@object);
		}
#pragma warning restore 0169

		static IntPtr id_free_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectPool']/method[@name='free' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("free", "(Ljava/lang/Object;)V", "GetFree_Ljava_lang_Object_Handler")]
		public virtual unsafe void Free (global::Java.Lang.Object @object)
		{
			if (id_free_Ljava_lang_Object_ == IntPtr.Zero)
				id_free_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "free", "(Ljava/lang/Object;)V");
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__object);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_free_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "free", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static Delegate cb_newObject;
#pragma warning disable 0169
		static Delegate GetNewObjectHandler ()
		{
			if (cb_newObject == null)
				cb_newObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewObject);
			return cb_newObject;
		}

		static IntPtr n_NewObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewObject ());
		}
#pragma warning restore 0169

		static IntPtr id_newObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectPool']/method[@name='newObject' and count(parameter)=0]"
		[Register ("newObject", "()Ljava/lang/Object;", "GetNewObjectHandler")]
		public virtual unsafe global::Java.Lang.Object NewObject ()
		{
			if (id_newObject == IntPtr.Zero)
				id_newObject = JNIEnv.GetMethodID (class_ref, "newObject", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newObject), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
