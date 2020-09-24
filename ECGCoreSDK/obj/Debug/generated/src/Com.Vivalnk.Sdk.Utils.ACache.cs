using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ACache", DoNotGenerateAcw=true)]
	public partial class ACache : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='MAX_COUNT']"
		[Register ("MAX_COUNT")]
		public const int MaxCount = (int) 2147483647;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='MAX_SIZE']"
		[Register ("MAX_SIZE")]
		public const int MaxSize = (int) 100000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='TIME_DAY']"
		[Register ("TIME_DAY")]
		public const int TimeDay = (int) 86400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='TIME_HOUR']"
		[Register ("TIME_HOUR")]
		public const int TimeHour = (int) 3600;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='mCache']"
		[Register ("mCache")]
		public global::Com.Vivalnk.Sdk.Utils.ACache.ACacheManager MCache {
			get {
				const string __id = "mCache.Lcom/vivalnk/sdk/utils/ACache$ACacheManager;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache.ACacheManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCache.Lcom/vivalnk/sdk/utils/ACache$ACacheManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/field[@name='mInstanceMap']"
		[Register ("mInstanceMap")]
		public static global::System.Collections.IDictionary MInstanceMap {
			get {
				const string __id = "mInstanceMap.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mInstanceMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ACache$ACacheManager", DoNotGenerateAcw=true)]
		public partial class ACacheManager : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='cacheCount']"
			[Register ("cacheCount")]
			public global::Java.Util.Concurrent.Atomic.AtomicInteger CacheCount {
				get {
					const string __id = "cacheCount.Ljava/util/concurrent/atomic/AtomicInteger;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "cacheCount.Ljava/util/concurrent/atomic/AtomicInteger;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='cacheDir']"
			[Register ("cacheDir")]
			public global::Java.IO.File CacheDir {
				get {
					const string __id = "cacheDir.Ljava/io/File;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "cacheDir.Ljava/io/File;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='cacheSize']"
			[Register ("cacheSize")]
			public global::Java.Util.Concurrent.Atomic.AtomicLong CacheSize {
				get {
					const string __id = "cacheSize.Ljava/util/concurrent/atomic/AtomicLong;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicLong> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "cacheSize.Ljava/util/concurrent/atomic/AtomicLong;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='countLimit']"
			[Register ("countLimit")]
			public int CountLimit {
				get {
					const string __id = "countLimit.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "countLimit.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='lastUsageDates']"
			[Register ("lastUsageDates")]
			public global::System.Collections.IDictionary LastUsageDates {
				get {
					const string __id = "lastUsageDates.Ljava/util/Map;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "lastUsageDates.Ljava/util/Map;";

					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/field[@name='sizeLimit']"
			[Register ("sizeLimit")]
			public long SizeLimit {
				get {
					const string __id = "sizeLimit.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "sizeLimit.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/ACache$ACacheManager", typeof (ACacheManager));
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

			protected ACacheManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.ACacheManager']/constructor[@name='ACache.ACacheManager' and count(parameter)=4 and parameter[1][@type='com.vivalnk.sdk.utils.ACache'] and parameter[2][@type='java.io.File'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/utils/ACache;Ljava/io/File;JI)V", "")]
			public unsafe ACacheManager (global::Com.Vivalnk.Sdk.Utils.ACache __self, global::Java.IO.File p0, long p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/io/File;JI)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [2] = new JniArgumentValue (p1);
					__args [3] = new JniArgumentValue (p2);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ACache$Utils", DoNotGenerateAcw=true)]
		public partial class Utils : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/field[@name='mSeparator']"
			[Register ("mSeparator")]
			public const char MSeparator = (char) (char)32;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/ACache$Utils", typeof (Utils));
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

			protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/constructor[@name='ACache.Utils' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Utils ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='Bitmap2Bytes' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("Bitmap2Bytes", "(Landroid/graphics/Bitmap;)[B", "")]
			public static unsafe byte[] Bitmap2Bytes (global::Android.Graphics.Bitmap p0)
			{
				const string __id = "Bitmap2Bytes.(Landroid/graphics/Bitmap;)[B";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='Bytes2Bimap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("Bytes2Bimap", "([B)Landroid/graphics/Bitmap;", "")]
			public static unsafe global::Android.Graphics.Bitmap Bytes2Bimap (byte[] p0)
			{
				const string __id = "Bytes2Bimap.([B)Landroid/graphics/Bitmap;";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='bitmap2Drawable' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("bitmap2Drawable", "(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;", "")]
			public static unsafe global::Android.Graphics.Drawables.Drawable Bitmap2Drawable (global::Android.Graphics.Bitmap p0)
			{
				const string __id = "bitmap2Drawable.(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='clearDateInfo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("clearDateInfo", "([B)[B", "")]
			public static unsafe byte[] ClearDateInfo (byte[] p0)
			{
				const string __id = "clearDateInfo.([B)[B";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='clearDateInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("clearDateInfo", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public static unsafe string ClearDateInfo (string p0)
			{
				const string __id = "clearDateInfo.(Ljava/lang/String;)Ljava/lang/String;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='copyOfRange' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("copyOfRange", "([BII)[B", "")]
			public static unsafe byte[] CopyOfRange (byte[] p0, int p1, int p2)
			{
				const string __id = "copyOfRange.([BII)[B";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='createDateInfo' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("createDateInfo", "(I)Ljava/lang/String;", "")]
			public static unsafe string CreateDateInfo (int p0)
			{
				const string __id = "createDateInfo.(I)Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='drawable2Bitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("drawable2Bitmap", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;", "")]
			public static unsafe global::Android.Graphics.Bitmap Drawable2Bitmap (global::Android.Graphics.Drawables.Drawable p0)
			{
				const string __id = "drawable2Bitmap.(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Bitmap;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='getDateInfoFromDate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("getDateInfoFromDate", "([B)[Ljava/lang/String;", "")]
			public static unsafe string[] GetDateInfoFromDate (byte[] p0)
			{
				const string __id = "getDateInfoFromDate.([B)[Ljava/lang/String;";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='hasDateInfo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("hasDateInfo", "([B)Z", "")]
			public static unsafe bool HasDateInfo (byte[] p0)
			{
				const string __id = "hasDateInfo.([B)Z";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='indexOf' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='char']]"
			[Register ("indexOf", "([BC)I", "")]
			public static unsafe int IndexOf (byte[] p0, char p1)
			{
				const string __id = "indexOf.([BC)I";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='isDue' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("isDue", "([B)Z", "")]
			public static unsafe bool IsDue (byte[] p0)
			{
				const string __id = "isDue.([B)Z";
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='isDue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isDue", "(Ljava/lang/String;)Z", "")]
			public static unsafe bool IsDue (string p0)
			{
				const string __id = "isDue.(Ljava/lang/String;)Z";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='newByteArrayWithDateInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("newByteArrayWithDateInfo", "(I[B)[B", "")]
			public static unsafe byte[] NewByteArrayWithDateInfo (int p0, byte[] p1)
			{
				const string __id = "newByteArrayWithDateInfo.(I[B)[B";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache.Utils']/method[@name='newStringWithDateInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("newStringWithDateInfo", "(ILjava/lang/String;)Ljava/lang/String;", "")]
			public static unsafe string NewStringWithDateInfo (int p0, string p1)
			{
				const string __id = "newStringWithDateInfo.(ILjava/lang/String;)Ljava/lang/String;";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/ACache", typeof (ACache));
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

		protected ACache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/constructor[@name='ACache' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;JI)V", "")]
		public unsafe ACache (global::Java.IO.File p0, long p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_file_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFile_Ljava_lang_String_Handler ()
		{
			if (cb_file_Ljava_lang_String_ == null)
				cb_file_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_File_Ljava_lang_String_);
			return cb_file_Ljava_lang_String_;
		}

		static IntPtr n_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.File (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='file' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("file", "(Ljava/lang/String;)Ljava/io/File;", "GetFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.IO.File File (string p0)
		{
			const string __id = "file.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get ()
		{
			const string __id = "get.()Lcom/vivalnk/sdk/utils/ACache;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get (global::Android.Content.Context p0)
		{
			const string __id = "get.(Landroid/content/Context;)Lcom/vivalnk/sdk/utils/ACache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Landroid/content/Context;Ljava/lang/String;)Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get (global::Android.Content.Context p0, string p1)
		{
			const string __id = "get.(Landroid/content/Context;Ljava/lang/String;)Lcom/vivalnk/sdk/utils/ACache;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("get", "(Landroid/content/Context;JI)Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get (global::Android.Content.Context p0, long p1, int p2)
		{
			const string __id = "get.(Landroid/content/Context;JI)Lcom/vivalnk/sdk/utils/ACache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("get", "(Ljava/io/File;)Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get (global::Java.IO.File p0)
		{
			const string __id = "get.(Ljava/io/File;)Lcom/vivalnk/sdk/utils/ACache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("get", "(Ljava/io/File;JI)Lcom/vivalnk/sdk/utils/ACache;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.ACache Get (global::Java.IO.File p0, long p1, int p2)
		{
			const string __id = "get.(Ljava/io/File;JI)Lcom/vivalnk/sdk/utils/ACache;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAsBinary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsBinary_Ljava_lang_String_Handler ()
		{
			if (cb_getAsBinary_Ljava_lang_String_ == null)
				cb_getAsBinary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsBinary_Ljava_lang_String_);
			return cb_getAsBinary_Ljava_lang_String_;
		}

		static IntPtr n_GetAsBinary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAsBinary (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsBinary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsBinary", "(Ljava/lang/String;)[B", "GetGetAsBinary_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] GetAsBinary (string p0)
		{
			const string __id = "getAsBinary.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsBitmap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsBitmap_Ljava_lang_String_Handler ()
		{
			if (cb_getAsBitmap_Ljava_lang_String_ == null)
				cb_getAsBitmap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsBitmap_Ljava_lang_String_);
			return cb_getAsBitmap_Ljava_lang_String_;
		}

		static IntPtr n_GetAsBitmap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAsBitmap (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetAsBitmap_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetAsBitmap (string p0)
		{
			const string __id = "getAsBitmap.(Ljava/lang/String;)Landroid/graphics/Bitmap;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsDrawable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsDrawable_Ljava_lang_String_Handler ()
		{
			if (cb_getAsDrawable_Ljava_lang_String_ == null)
				cb_getAsDrawable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsDrawable_Ljava_lang_String_);
			return cb_getAsDrawable_Ljava_lang_String_;
		}

		static IntPtr n_GetAsDrawable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAsDrawable (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "GetGetAsDrawable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable GetAsDrawable (string p0)
		{
			const string __id = "getAsDrawable.(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsJSONArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsJSONArray_Ljava_lang_String_Handler ()
		{
			if (cb_getAsJSONArray_Ljava_lang_String_ == null)
				cb_getAsJSONArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsJSONArray_Ljava_lang_String_);
			return cb_getAsJSONArray_Ljava_lang_String_;
		}

		static IntPtr n_GetAsJSONArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAsJSONArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsJSONArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", "GetGetAsJSONArray_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Json.JSONArray GetAsJSONArray (string p0)
		{
			const string __id = "getAsJSONArray.(Ljava/lang/String;)Lorg/json/JSONArray;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsJSONObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsJSONObject_Ljava_lang_String_Handler ()
		{
			if (cb_getAsJSONObject_Ljava_lang_String_ == null)
				cb_getAsJSONObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsJSONObject_Ljava_lang_String_);
			return cb_getAsJSONObject_Ljava_lang_String_;
		}

		static IntPtr n_GetAsJSONObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAsJSONObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsJSONObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetAsJSONObject_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Json.JSONObject GetAsJSONObject (string p0)
		{
			const string __id = "getAsJSONObject.(Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsObject_Ljava_lang_String_Handler ()
		{
			if (cb_getAsObject_Ljava_lang_String_ == null)
				cb_getAsObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsObject_Ljava_lang_String_);
			return cb_getAsObject_Ljava_lang_String_;
		}

		static IntPtr n_GetAsObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAsObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsObject", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetAsObject_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAsObject (string p0)
		{
			const string __id = "getAsObject.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsString_Ljava_lang_String_Handler ()
		{
			if (cb_getAsString_Ljava_lang_String_ == null)
				cb_getAsString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAsString_Ljava_lang_String_);
			return cb_getAsString_Ljava_lang_String_;
		}

		static IntPtr n_GetAsString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAsString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='getAsString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAsString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetAsString (string p0)
		{
			const string __id = "getAsString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='myPid' and count(parameter)=0]"
		[Register ("myPid", "()Ljava/lang/String;", "")]
		public static unsafe string MyPid ()
		{
			const string __id = "myPid.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Put (string p0, global::Android.Graphics.Bitmap p1)
		{
			const string __id = "put.(Ljava/lang/String;Landroid/graphics/Bitmap;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_I == null)
				cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_I);
			return cb_put_Ljava_lang_String_Landroid_graphics_Bitmap_I;
		}

		static void n_Put_Ljava_lang_String_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/Bitmap;I)V", "GetPut_Ljava_lang_String_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe void Put (string p0, global::Android.Graphics.Bitmap p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Landroid/graphics/Bitmap;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == null)
				cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_);
			return cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
		}

		static void n_Put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "GetPut_Ljava_lang_String_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void Put (string p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			const string __id = "put.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Landroid_graphics_drawable_Drawable_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I == null)
				cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I);
			return cb_put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I;
		}

		static void n_Put_Ljava_lang_String_Landroid_graphics_drawable_Drawable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Landroid/graphics/drawable/Drawable;I)V", "GetPut_Ljava_lang_String_Landroid_graphics_drawable_Drawable_IHandler")]
		public virtual unsafe void Put (string p0, global::Android.Graphics.Drawables.Drawable p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Landroid/graphics/drawable/Drawable;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_arrayB;
		}

		static void n_Put_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Put (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)V", "GetPut_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void Put (string p0, byte[] p1)
		{
			const string __id = "put.(Ljava/lang/String;[B)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_put_Ljava_lang_String_arrayBI;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBIHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayBI == null)
				cb_put_Ljava_lang_String_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_arrayBI);
			return cb_put_Ljava_lang_String_arrayBI;
		}

		static void n_Put_Ljava_lang_String_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Put (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;[BI)V", "GetPut_Ljava_lang_String_arrayBIHandler")]
		public virtual unsafe void Put (string p0, byte[] p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;[BI)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_io_Serializable_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_io_Serializable_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_io_Serializable_ == null)
				cb_put_Ljava_lang_String_Ljava_io_Serializable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Ljava_io_Serializable_);
			return cb_put_Ljava_lang_String_Ljava_io_Serializable_;
		}

		static void n_Put_Ljava_lang_String_Ljava_io_Serializable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.IO.ISerializable)global::Java.Lang.Object.GetObject<global::Java.IO.ISerializable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.Serializable']]"
		[Register ("put", "(Ljava/lang/String;Ljava/io/Serializable;)V", "GetPut_Ljava_lang_String_Ljava_io_Serializable_Handler")]
		public virtual unsafe void Put (string p0, global::Java.IO.ISerializable p1)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/io/Serializable;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_io_Serializable_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_io_Serializable_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_io_Serializable_I == null)
				cb_put_Ljava_lang_String_Ljava_io_Serializable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Ljava_io_Serializable_I);
			return cb_put_Ljava_lang_String_Ljava_io_Serializable_I;
		}

		static void n_Put_Ljava_lang_String_Ljava_io_Serializable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.IO.ISerializable)global::Java.Lang.Object.GetObject<global::Java.IO.ISerializable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.Serializable'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Ljava/io/Serializable;I)V", "GetPut_Ljava_lang_String_Ljava_io_Serializable_IHandler")]
		public virtual unsafe void Put (string p0, global::Java.IO.ISerializable p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/io/Serializable;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string p0, string p1)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Ljava_lang_String_I);
			return cb_put_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetPut_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void Put (string p0, string p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_json_JSONArray_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_json_JSONArray_ == null)
				cb_put_Ljava_lang_String_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Lorg_json_JSONArray_);
			return cb_put_Ljava_lang_String_Lorg_json_JSONArray_;
		}

		static void n_Put_Ljava_lang_String_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray']]"
		[Register ("put", "(Ljava/lang/String;Lorg/json/JSONArray;)V", "GetPut_Ljava_lang_String_Lorg_json_JSONArray_Handler")]
		public virtual unsafe void Put (string p0, global::Org.Json.JSONArray p1)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/json/JSONArray;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_json_JSONArray_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_json_JSONArray_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_json_JSONArray_I == null)
				cb_put_Ljava_lang_String_Lorg_json_JSONArray_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Lorg_json_JSONArray_I);
			return cb_put_Ljava_lang_String_Lorg_json_JSONArray_I;
		}

		static void n_Put_Ljava_lang_String_Lorg_json_JSONArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Lorg/json/JSONArray;I)V", "GetPut_Ljava_lang_String_Lorg_json_JSONArray_IHandler")]
		public virtual unsafe void Put (string p0, global::Org.Json.JSONArray p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/json/JSONArray;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_put_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Put_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_put_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_Put_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("put", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetPut_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Put (string p0, global::Org.Json.JSONObject p1)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/json/JSONObject;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lorg_json_JSONObject_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lorg_json_JSONObject_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Lorg_json_JSONObject_I == null)
				cb_put_Ljava_lang_String_Lorg_json_JSONObject_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Put_Ljava_lang_String_Lorg_json_JSONObject_I);
			return cb_put_Ljava_lang_String_Lorg_json_JSONObject_I;
		}

		static void n_Put_Ljava_lang_String_Lorg_json_JSONObject_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Lorg/json/JSONObject;I)V", "GetPut_Ljava_lang_String_Lorg_json_JSONObject_IHandler")]
		public virtual unsafe void Put (string p0, global::Org.Json.JSONObject p1, int p2)
		{
			const string __id = "put.(Ljava/lang/String;Lorg/json/JSONObject;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static bool n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.ACache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ACache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe bool Remove (string p0)
		{
			const string __id = "remove.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
