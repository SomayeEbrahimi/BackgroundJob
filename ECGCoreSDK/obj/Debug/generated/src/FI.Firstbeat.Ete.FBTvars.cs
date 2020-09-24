using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FI.Firstbeat.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']"
	[global::Android.Runtime.Register ("fi/firstbeat/ete/FBTvars", DoNotGenerateAcw=true)]
	public partial class FBTvars : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='AC']"
		[Register ("AC")]
		public int Ac {
			get {
				const string __id = "AC.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "AC.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='AT']"
		[Register ("AT")]
		public IList<int> At {
			get {
				const string __id = "AT.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "AT.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='age']"
		[Register ("age")]
		public int Age {
			get {
				const string __id = "age.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "age.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='gender']"
		[Register ("gender")]
		public int Gender {
			get {
				const string __id = "gender.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "gender.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='maxHr']"
		[Register ("maxHr")]
		public int MaxHr {
			get {
				const string __id = "maxHr.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxHr.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='maxMET']"
		[Register ("maxMET")]
		public int MaxMET {
			get {
				const string __id = "maxMET.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxMET.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='maxSleepQuality']"
		[Register ("maxSleepQuality")]
		public int MaxSleepQuality {
			get {
				const string __id = "maxSleepQuality.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxSleepQuality.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='meanMAD']"
		[Register ("meanMAD")]
		public int MeanMAD {
			get {
				const string __id = "meanMAD.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "meanMAD.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='minHr']"
		[Register ("minHr")]
		public int MinHr {
			get {
				const string __id = "minHr.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "minHr.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='monthlyLoad']"
		[Register ("monthlyLoad")]
		public int MonthlyLoad {
			get {
				const string __id = "monthlyLoad.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "monthlyLoad.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='resourceRecovery']"
		[Register ("resourceRecovery")]
		public int ResourceRecovery {
			get {
				const string __id = "resourceRecovery.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "resourceRecovery.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/field[@name='weight']"
		[Register ("weight")]
		public int Weight {
			get {
				const string __id = "weight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "weight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("fi/firstbeat/ete/FBTvars", typeof (FBTvars));
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

		protected FBTvars (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTvars']/constructor[@name='FBTvars' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FBTvars ()
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
}
