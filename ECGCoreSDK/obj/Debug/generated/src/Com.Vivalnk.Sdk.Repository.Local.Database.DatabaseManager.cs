using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/DatabaseManager", DoNotGenerateAcw=true)]
	public partial class DatabaseManager : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Repository.Local.Database.IDBManager {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/field[@name='FLAG_USE_OBJECTBOX']"
		[Register ("FLAG_USE_OBJECTBOX")]
		public const string FlagUseObjectbox = (string) "FLAG_USE_OBJECTBOX";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/field[@name='FLAG_USE_ROOM']"
		[Register ("FLAG_USE_ROOM")]
		public const string FlagUseRoom = (string) "FLAG_USE_ROOM";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/field[@name='mIDataDAO']"
		[Register ("mIDataDAO")]
		public global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO MIDataDAO {
			get {
				const string __id = "mIDataDAO.Lcom/vivalnk/sdk/repository/local/database/IDataDAO;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIDataDAO.Lcom/vivalnk/sdk/repository/local/database/IDataDAO;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/field[@name='mIDeviceDAO']"
		[Register ("mIDeviceDAO")]
		public global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO MIDeviceDAO {
			get {
				const string __id = "mIDeviceDAO.Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIDeviceDAO.Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager.SingletonHolder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/DatabaseManager$SingletonHolder", DoNotGenerateAcw=true)]
		public partial class SingletonHolder : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager.SingletonHolder']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager Instance {
				get {
					const string __id = "INSTANCE.Lcom/vivalnk/sdk/repository/local/database/DatabaseManager;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/DatabaseManager$SingletonHolder", typeof (SingletonHolder));
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

			protected SingletonHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager.SingletonHolder']/constructor[@name='DatabaseManager.SingletonHolder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SingletonHolder ()
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/DatabaseManager", typeof (DatabaseManager));
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

		protected DatabaseManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/constructor[@name='DatabaseManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatabaseManager ()
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

		static Delegate cb_getDataDAO;
#pragma warning disable 0169
		static Delegate GetGetDataDAOHandler ()
		{
			if (cb_getDataDAO == null)
				cb_getDataDAO = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataDAO);
			return cb_getDataDAO;
		}

		static IntPtr n_GetDataDAO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataDAO);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO DataDAO {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/method[@name='getDataDAO' and count(parameter)=0]"
			[Register ("getDataDAO", "()Lcom/vivalnk/sdk/repository/local/database/IDataDAO;", "GetGetDataDAOHandler")]
			get {
				const string __id = "getDataDAO.()Lcom/vivalnk/sdk/repository/local/database/IDataDAO;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceDAO;
#pragma warning disable 0169
		static Delegate GetGetDeviceDAOHandler ()
		{
			if (cb_getDeviceDAO == null)
				cb_getDeviceDAO = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceDAO);
			return cb_getDeviceDAO;
		}

		static IntPtr n_GetDeviceDAO (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceDAO);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO DeviceDAO {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/method[@name='getDeviceDAO' and count(parameter)=0]"
			[Register ("getDeviceDAO", "()Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;", "GetGetDeviceDAOHandler")]
			get {
				const string __id = "getDeviceDAO.()Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/vivalnk/sdk/repository/local/database/DatabaseManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/vivalnk/sdk/repository/local/database/DatabaseManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_init_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_init_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_init_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Init_Landroid_content_Context_Ljava_lang_String_);
			return cb_init_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_Init_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "GetInit_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, string p1)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_Handler ()
		{
			if (cb_init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_ == null)
				cb_init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_);
			return cb_init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_;
		}

		static void n_Init_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database']/class[@name='DatabaseManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.IDeviceDAO'] and parameter[2][@type='com.vivalnk.sdk.repository.local.database.IDataDAO']]"
		[Register ("init", "(Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;Lcom/vivalnk/sdk/repository/local/database/IDataDAO;)V", "GetInit_Lcom_vivalnk_sdk_repository_local_database_IDeviceDAO_Lcom_vivalnk_sdk_repository_local_database_IDataDAO_Handler")]
		public virtual unsafe void Init (global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO p0, global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO p1)
		{
			const string __id = "init.(Lcom/vivalnk/sdk/repository/local/database/IDeviceDAO;Lcom/vivalnk/sdk/repository/local/database/IDataDAO;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
