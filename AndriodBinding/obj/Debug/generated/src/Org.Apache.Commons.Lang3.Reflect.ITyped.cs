using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/interface[@name='Typed']"
	[Register ("org/apache/commons/lang3/reflect/Typed", "", "Org.Apache.Commons.Lang3.Reflect.ITypedInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITyped : IJavaObject {

		global::Java.Lang.Reflect.IType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/interface[@name='Typed']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/reflect/Type;", "GetGetTypeHandler:Org.Apache.Commons.Lang3.Reflect.ITypedInvoker, AndriodBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/Typed", DoNotGenerateAcw=true)]
	internal partial class ITypedInvoker : global::Java.Lang.Object, ITyped {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/reflect/Typed");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITypedInvoker); }
		}

		IntPtr class_ref;

		public static ITyped GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITyped> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.reflect.Typed"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Reflect.ITyped> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Java.Lang.Reflect.IType Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/reflect/Type;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
