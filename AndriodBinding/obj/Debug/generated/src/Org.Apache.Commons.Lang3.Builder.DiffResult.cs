using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/builder/DiffResult", DoNotGenerateAcw=true)]
	public partial class DiffResult : global::Java.Lang.Object, global::Java.Lang.IIterable {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/field[@name='OBJECTS_SAME_STRING']"
		[Register ("OBJECTS_SAME_STRING")]
		public const string ObjectsSameString = (string) "";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/builder/DiffResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiffResult); }
		}

		protected DiffResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDiffs;
#pragma warning disable 0169
		static Delegate GetGetDiffsHandler ()
		{
			if (cb_getDiffs == null)
				cb_getDiffs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDiffs);
			return cb_getDiffs;
		}

		static IntPtr n_GetDiffs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Builder.Diff>.ToLocalJniHandle (__this.Diffs);
		}
#pragma warning restore 0169

		static IntPtr id_getDiffs;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Apache.Commons.Lang3.Builder.Diff> Diffs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/method[@name='getDiffs' and count(parameter)=0]"
			[Register ("getDiffs", "()Ljava/util/List;", "GetGetDiffsHandler")]
			get {
				if (id_getDiffs == IntPtr.Zero)
					id_getDiffs = JNIEnv.GetMethodID (class_ref, "getDiffs", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Builder.Diff>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDiffs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Apache.Commons.Lang3.Builder.Diff>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiffs", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfDiffs;
#pragma warning disable 0169
		static Delegate GetGetNumberOfDiffsHandler ()
		{
			if (cb_getNumberOfDiffs == null)
				cb_getNumberOfDiffs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNumberOfDiffs);
			return cb_getNumberOfDiffs;
		}

		static int n_GetNumberOfDiffs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfDiffs;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfDiffs;
		public virtual unsafe int NumberOfDiffs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/method[@name='getNumberOfDiffs' and count(parameter)=0]"
			[Register ("getNumberOfDiffs", "()I", "GetGetNumberOfDiffsHandler")]
			get {
				if (id_getNumberOfDiffs == IntPtr.Zero)
					id_getNumberOfDiffs = JNIEnv.GetMethodID (class_ref, "getNumberOfDiffs", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfDiffs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfDiffs", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getToStringStyle;
#pragma warning disable 0169
		static Delegate GetGetToStringStyleHandler ()
		{
			if (cb_getToStringStyle == null)
				cb_getToStringStyle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToStringStyle);
			return cb_getToStringStyle;
		}

		static IntPtr n_GetToStringStyle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToStringStyle);
		}
#pragma warning restore 0169

		static IntPtr id_getToStringStyle;
		public virtual unsafe global::Org.Apache.Commons.Lang3.Builder.ToStringStyle ToStringStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/method[@name='getToStringStyle' and count(parameter)=0]"
			[Register ("getToStringStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;", "GetGetToStringStyleHandler")]
			get {
				if (id_getToStringStyle == IntPtr.Zero)
					id_getToStringStyle = JNIEnv.GetMethodID (class_ref, "getToStringStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToStringStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToStringStyle", "()Lorg/apache/commons/lang3/builder/ToStringStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_;
#pragma warning disable 0169
		static Delegate GetToString_Lorg_apache_commons_lang3_builder_ToStringStyle_Handler ()
		{
			if (cb_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_ == null)
				cb_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ToString_Lorg_apache_commons_lang3_builder_ToStringStyle_);
			return cb_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		}

		static IntPtr n_ToString_Lorg_apache_commons_lang3_builder_ToStringStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.DiffResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var style = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Builder.ToStringStyle> (native_style, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToString (style));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.builder']/class[@name='DiffResult']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.builder.ToStringStyle']]"
		[Register ("toString", "(Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;", "GetToString_Lorg_apache_commons_lang3_builder_ToStringStyle_Handler")]
		public virtual unsafe string ToString (global::Org.Apache.Commons.Lang3.Builder.ToStringStyle style)
		{
			if (id_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_ == IntPtr.Zero)
				id_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_ = JNIEnv.GetMethodID (class_ref, "toString", "(Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (style);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString_Lorg_apache_commons_lang3_builder_ToStringStyle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "(Lorg/apache/commons/lang3/builder/ToStringStyle;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
