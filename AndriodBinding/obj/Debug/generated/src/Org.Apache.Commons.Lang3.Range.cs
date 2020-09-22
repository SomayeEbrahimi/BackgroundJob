using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/Range", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Range : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/Range", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Range); }
		}

		internal Range (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getComparator;
		public unsafe global::Java.Util.IComparator Comparator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='getComparator' and count(parameter)=0]"
			[Register ("getComparator", "()Ljava/util/Comparator;", "")]
			get {
				if (id_getComparator == IntPtr.Zero)
					id_getComparator = JNIEnv.GetMethodID (class_ref, "getComparator", "()Ljava/util/Comparator;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComparator), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isNaturalOrdering;
		public unsafe bool IsNaturalOrdering {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isNaturalOrdering' and count(parameter)=0]"
			[Register ("isNaturalOrdering", "()Z", "")]
			get {
				if (id_isNaturalOrdering == IntPtr.Zero)
					id_isNaturalOrdering = JNIEnv.GetMethodID (class_ref, "isNaturalOrdering", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNaturalOrdering);
				} finally {
				}
			}
		}

		static IntPtr id_getMaximum;
		public unsafe global::Java.Lang.Object Maximum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='getMaximum' and count(parameter)=0]"
			[Register ("getMaximum", "()Ljava/lang/Object;", "")]
			get {
				if (id_getMaximum == IntPtr.Zero)
					id_getMaximum = JNIEnv.GetMethodID (class_ref, "getMaximum", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaximum), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMinimum;
		public unsafe global::Java.Lang.Object Minimum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='getMinimum' and count(parameter)=0]"
			[Register ("getMinimum", "()Ljava/lang/Object;", "")]
			get {
				if (id_getMinimum == IntPtr.Zero)
					id_getMinimum = JNIEnv.GetMethodID (class_ref, "getMinimum", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinimum), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_between_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='between' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("between", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/Range;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<T>"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Range Between (global::Java.Lang.Object fromInclusive, global::Java.Lang.Object toInclusive)
		{
			if (id_between_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_between_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "between", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/Range;");
			IntPtr native_fromInclusive = JNIEnv.ToLocalJniHandle (fromInclusive);
			IntPtr native_toInclusive = JNIEnv.ToLocalJniHandle (toInclusive);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fromInclusive);
				__args [1] = new JValue (native_toInclusive);
				global::Org.Apache.Commons.Lang3.Range __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Range> (JNIEnv.CallStaticObjectMethod  (class_ref, id_between_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromInclusive);
				JNIEnv.DeleteLocalRef (native_toInclusive);
			}
		}

		static IntPtr id_between_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='between' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("between", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/Range;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Range Between (global::Java.Lang.Object fromInclusive, global::Java.Lang.Object toInclusive, global::Java.Util.IComparator comparator)
		{
			if (id_between_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ == IntPtr.Zero)
				id_between_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_ = JNIEnv.GetStaticMethodID (class_ref, "between", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/Range;");
			IntPtr native_fromInclusive = JNIEnv.ToLocalJniHandle (fromInclusive);
			IntPtr native_toInclusive = JNIEnv.ToLocalJniHandle (toInclusive);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fromInclusive);
				__args [1] = new JValue (native_toInclusive);
				__args [2] = new JValue (comparator);
				global::Org.Apache.Commons.Lang3.Range __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Range> (JNIEnv.CallStaticObjectMethod  (class_ref, id_between_Ljava_lang_Object_Ljava_lang_Object_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromInclusive);
				JNIEnv.DeleteLocalRef (native_toInclusive);
			}
		}

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains (global::Java.Lang.Object element)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_containsRange_Lorg_apache_commons_lang3_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='containsRange' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.Range&lt;T&gt;']]"
		[Register ("containsRange", "(Lorg/apache/commons/lang3/Range;)Z", "")]
		public unsafe bool ContainsRange (global::Org.Apache.Commons.Lang3.Range otherRange)
		{
			if (id_containsRange_Lorg_apache_commons_lang3_Range_ == IntPtr.Zero)
				id_containsRange_Lorg_apache_commons_lang3_Range_ = JNIEnv.GetMethodID (class_ref, "containsRange", "(Lorg/apache/commons/lang3/Range;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (otherRange);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsRange_Lorg_apache_commons_lang3_Range_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_elementCompareTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='elementCompareTo' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("elementCompareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int ElementCompareTo (global::Java.Lang.Object element)
		{
			if (id_elementCompareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_elementCompareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "elementCompareTo", "(Ljava/lang/Object;)I");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_elementCompareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_intersectionWith_Lorg_apache_commons_lang3_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='intersectionWith' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.Range&lt;T&gt;']]"
		[Register ("intersectionWith", "(Lorg/apache/commons/lang3/Range;)Lorg/apache/commons/lang3/Range;", "")]
		public unsafe global::Org.Apache.Commons.Lang3.Range IntersectionWith (global::Org.Apache.Commons.Lang3.Range other)
		{
			if (id_intersectionWith_Lorg_apache_commons_lang3_Range_ == IntPtr.Zero)
				id_intersectionWith_Lorg_apache_commons_lang3_Range_ = JNIEnv.GetMethodID (class_ref, "intersectionWith", "(Lorg/apache/commons/lang3/Range;)Lorg/apache/commons/lang3/Range;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::Org.Apache.Commons.Lang3.Range __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Range> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intersectionWith_Lorg_apache_commons_lang3_Range_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_is_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='is' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("is", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/Range;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<T>"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Range Is (global::Java.Lang.Object element)
		{
			if (id_is_Ljava_lang_Object_ == IntPtr.Zero)
				id_is_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "is", "(Ljava/lang/Object;)Lorg/apache/commons/lang3/Range;");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				global::Org.Apache.Commons.Lang3.Range __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Range> (JNIEnv.CallStaticObjectMethod  (class_ref, id_is_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_is_Ljava_lang_Object_Ljava_util_Comparator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='is' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("is", "(Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/Range;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Range Is (global::Java.Lang.Object element, global::Java.Util.IComparator comparator)
		{
			if (id_is_Ljava_lang_Object_Ljava_util_Comparator_ == IntPtr.Zero)
				id_is_Ljava_lang_Object_Ljava_util_Comparator_ = JNIEnv.GetStaticMethodID (class_ref, "is", "(Ljava/lang/Object;Ljava/util/Comparator;)Lorg/apache/commons/lang3/Range;");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_element);
				__args [1] = new JValue (comparator);
				global::Org.Apache.Commons.Lang3.Range __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Range> (JNIEnv.CallStaticObjectMethod  (class_ref, id_is_Ljava_lang_Object_Ljava_util_Comparator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_isAfter_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isAfter' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("isAfter", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool IsAfter (global::Java.Lang.Object element)
		{
			if (id_isAfter_Ljava_lang_Object_ == IntPtr.Zero)
				id_isAfter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isAfter", "(Ljava/lang/Object;)Z");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAfter_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_isAfterRange_Lorg_apache_commons_lang3_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isAfterRange' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.Range&lt;T&gt;']]"
		[Register ("isAfterRange", "(Lorg/apache/commons/lang3/Range;)Z", "")]
		public unsafe bool IsAfterRange (global::Org.Apache.Commons.Lang3.Range otherRange)
		{
			if (id_isAfterRange_Lorg_apache_commons_lang3_Range_ == IntPtr.Zero)
				id_isAfterRange_Lorg_apache_commons_lang3_Range_ = JNIEnv.GetMethodID (class_ref, "isAfterRange", "(Lorg/apache/commons/lang3/Range;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (otherRange);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAfterRange_Lorg_apache_commons_lang3_Range_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isBefore_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isBefore' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("isBefore", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool IsBefore (global::Java.Lang.Object element)
		{
			if (id_isBefore_Ljava_lang_Object_ == IntPtr.Zero)
				id_isBefore_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isBefore", "(Ljava/lang/Object;)Z");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBefore_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_isBeforeRange_Lorg_apache_commons_lang3_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isBeforeRange' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.Range&lt;T&gt;']]"
		[Register ("isBeforeRange", "(Lorg/apache/commons/lang3/Range;)Z", "")]
		public unsafe bool IsBeforeRange (global::Org.Apache.Commons.Lang3.Range otherRange)
		{
			if (id_isBeforeRange_Lorg_apache_commons_lang3_Range_ == IntPtr.Zero)
				id_isBeforeRange_Lorg_apache_commons_lang3_Range_ = JNIEnv.GetMethodID (class_ref, "isBeforeRange", "(Lorg/apache/commons/lang3/Range;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (otherRange);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBeforeRange_Lorg_apache_commons_lang3_Range_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isEndedBy_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isEndedBy' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("isEndedBy", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool IsEndedBy (global::Java.Lang.Object element)
		{
			if (id_isEndedBy_Ljava_lang_Object_ == IntPtr.Zero)
				id_isEndedBy_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isEndedBy", "(Ljava/lang/Object;)Z");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEndedBy_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_isOverlappedBy_Lorg_apache_commons_lang3_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isOverlappedBy' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.Range&lt;T&gt;']]"
		[Register ("isOverlappedBy", "(Lorg/apache/commons/lang3/Range;)Z", "")]
		public unsafe bool IsOverlappedBy (global::Org.Apache.Commons.Lang3.Range otherRange)
		{
			if (id_isOverlappedBy_Lorg_apache_commons_lang3_Range_ == IntPtr.Zero)
				id_isOverlappedBy_Lorg_apache_commons_lang3_Range_ = JNIEnv.GetMethodID (class_ref, "isOverlappedBy", "(Lorg/apache/commons/lang3/Range;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (otherRange);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOverlappedBy_Lorg_apache_commons_lang3_Range_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isStartedBy_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='isStartedBy' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("isStartedBy", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool IsStartedBy (global::Java.Lang.Object element)
		{
			if (id_isStartedBy_Ljava_lang_Object_ == IntPtr.Zero)
				id_isStartedBy_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isStartedBy", "(Ljava/lang/Object;)Z");
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_element);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartedBy_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		static IntPtr id_toString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Range']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ToString (string format)
		{
			if (id_toString_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_format);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

	}
}
