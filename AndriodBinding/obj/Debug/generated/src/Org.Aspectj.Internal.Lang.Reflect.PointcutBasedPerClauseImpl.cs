using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Internal.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='PointcutBasedPerClauseImpl']"
	[global::Android.Runtime.Register ("org/aspectj/internal/lang/reflect/PointcutBasedPerClauseImpl", DoNotGenerateAcw=true)]
	public partial class PointcutBasedPerClauseImpl : global::Org.Aspectj.Internal.Lang.Reflect.PerClauseImpl, global::Org.Aspectj.Lang.Reflect.IPointcutBasedPerClause {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/internal/lang/reflect/PointcutBasedPerClauseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PointcutBasedPerClauseImpl); }
		}

		protected PointcutBasedPerClauseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='PointcutBasedPerClauseImpl']/constructor[@name='PointcutBasedPerClauseImpl' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.PerClauseKind'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", "")]
		public unsafe PointcutBasedPerClauseImpl (global::Org.Aspectj.Lang.Reflect.PerClauseKind kind, string pointcutExpression)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_pointcutExpression = JNIEnv.NewString (pointcutExpression);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (kind);
				__args [1] = new JValue (native_pointcutExpression);
				if (((object) this).GetType () != typeof (PointcutBasedPerClauseImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/aspectj/lang/reflect/PerClauseKind;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_aspectj_lang_reflect_PerClauseKind_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pointcutExpression);
			}
		}

		static Delegate cb_getPointcutExpression;
#pragma warning disable 0169
		static Delegate GetGetPointcutExpressionHandler ()
		{
			if (cb_getPointcutExpression == null)
				cb_getPointcutExpression = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPointcutExpression);
			return cb_getPointcutExpression;
		}

		static IntPtr n_GetPointcutExpression (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Reflect.PointcutBasedPerClauseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointcutExpression);
		}
#pragma warning restore 0169

		static IntPtr id_getPointcutExpression;
		public virtual unsafe global::Org.Aspectj.Lang.Reflect.IPointcutExpression PointcutExpression {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.reflect']/class[@name='PointcutBasedPerClauseImpl']/method[@name='getPointcutExpression' and count(parameter)=0]"
			[Register ("getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;", "GetGetPointcutExpressionHandler")]
			get {
				if (id_getPointcutExpression == IntPtr.Zero)
					id_getPointcutExpression = JNIEnv.GetMethodID (class_ref, "getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutExpression> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointcutExpression), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcutExpression> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointcutExpression", "()Lorg/aspectj/lang/reflect/PointcutExpression;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
