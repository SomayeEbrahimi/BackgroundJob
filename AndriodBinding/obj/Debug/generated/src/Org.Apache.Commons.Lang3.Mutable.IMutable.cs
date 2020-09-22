using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Mutable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']"
	[Register ("org/apache/commons/lang3/mutable/Mutable", "", "Org.Apache.Commons.Lang3.Mutable.IMutableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IMutable : IJavaObject {

		global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] set;
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/mutable/Mutable", DoNotGenerateAcw=true)]
	internal partial class IMutableInvoker : global::Java.Lang.Object, IMutable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/mutable/Mutable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMutableInvoker); }
		}

		IntPtr class_ref;

		public static IMutable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMutable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.mutable.Mutable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMutableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.IMutable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_Handler ()
		{
			if (cb_setValue_Ljava_lang_Object_ == null)
				cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_Object_);
			return cb_setValue_Ljava_lang_Object_;
		}

		static void n_SetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.IMutable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValue;
		IntPtr id_setValue_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Value {
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
					id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}

}
