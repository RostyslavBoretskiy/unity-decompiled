﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.ConfigurableJoint
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The configurable joint is an extremely flexible joint giving you complete control over rotation and linear motion.</para>
  /// </summary>
  public sealed class ConfigurableJoint : Joint
  {
    /// <summary>
    ///   <para>The joint's secondary axis.</para>
    /// </summary>
    public Vector3 secondaryAxis
    {
      get
      {
        Vector3 vector3;
        this.INTERNAL_get_secondaryAxis(out vector3);
        return vector3;
      }
      set
      {
        this.INTERNAL_set_secondaryAxis(ref value);
      }
    }

    /// <summary>
    ///   <para>Allow movement along the X axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
    /// </summary>
    public ConfigurableJointMotion xMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allow movement along the Y axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
    /// </summary>
    public ConfigurableJointMotion yMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allow movement along the Z axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
    /// </summary>
    public ConfigurableJointMotion zMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allow rotation around the X axis to be Free, completely Locked, or Limited according to Low and High Angular XLimit.</para>
    /// </summary>
    public ConfigurableJointMotion angularXMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allow rotation around the Y axis to be Free, completely Locked, or Limited according to Angular YLimit.</para>
    /// </summary>
    public ConfigurableJointMotion angularYMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allow rotation around the Z axis to be Free, completely Locked, or Limited according to Angular ZLimit.</para>
    /// </summary>
    public ConfigurableJointMotion angularZMotion { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The configuration of the spring attached to the linear limit of the joint.</para>
    /// </summary>
    public SoftJointLimitSpring linearLimitSpring
    {
      get
      {
        SoftJointLimitSpring jointLimitSpring;
        this.INTERNAL_get_linearLimitSpring(out jointLimitSpring);
        return jointLimitSpring;
      }
      set
      {
        this.INTERNAL_set_linearLimitSpring(ref value);
      }
    }

    /// <summary>
    ///   <para>The configuration of the spring attached to the angular X limit of the joint.</para>
    /// </summary>
    public SoftJointLimitSpring angularXLimitSpring
    {
      get
      {
        SoftJointLimitSpring jointLimitSpring;
        this.INTERNAL_get_angularXLimitSpring(out jointLimitSpring);
        return jointLimitSpring;
      }
      set
      {
        this.INTERNAL_set_angularXLimitSpring(ref value);
      }
    }

    /// <summary>
    ///   <para>The configuration of the spring attached to the angular Y and angular Z limits of the joint.</para>
    /// </summary>
    public SoftJointLimitSpring angularYZLimitSpring
    {
      get
      {
        SoftJointLimitSpring jointLimitSpring;
        this.INTERNAL_get_angularYZLimitSpring(out jointLimitSpring);
        return jointLimitSpring;
      }
      set
      {
        this.INTERNAL_set_angularYZLimitSpring(ref value);
      }
    }

    /// <summary>
    ///   <para>Boundary defining movement restriction, based on distance from the joint's origin.</para>
    /// </summary>
    public SoftJointLimit linearLimit
    {
      get
      {
        SoftJointLimit softJointLimit;
        this.INTERNAL_get_linearLimit(out softJointLimit);
        return softJointLimit;
      }
      set
      {
        this.INTERNAL_set_linearLimit(ref value);
      }
    }

    /// <summary>
    ///   <para>Boundary defining lower rotation restriction, based on delta from original rotation.</para>
    /// </summary>
    public SoftJointLimit lowAngularXLimit
    {
      get
      {
        SoftJointLimit softJointLimit;
        this.INTERNAL_get_lowAngularXLimit(out softJointLimit);
        return softJointLimit;
      }
      set
      {
        this.INTERNAL_set_lowAngularXLimit(ref value);
      }
    }

    /// <summary>
    ///   <para>Boundary defining upper rotation restriction, based on delta from original rotation.</para>
    /// </summary>
    public SoftJointLimit highAngularXLimit
    {
      get
      {
        SoftJointLimit softJointLimit;
        this.INTERNAL_get_highAngularXLimit(out softJointLimit);
        return softJointLimit;
      }
      set
      {
        this.INTERNAL_set_highAngularXLimit(ref value);
      }
    }

    /// <summary>
    ///   <para>Boundary defining rotation restriction, based on delta from original rotation.</para>
    /// </summary>
    public SoftJointLimit angularYLimit
    {
      get
      {
        SoftJointLimit softJointLimit;
        this.INTERNAL_get_angularYLimit(out softJointLimit);
        return softJointLimit;
      }
      set
      {
        this.INTERNAL_set_angularYLimit(ref value);
      }
    }

    /// <summary>
    ///   <para>Boundary defining rotation restriction, based on delta from original rotation.</para>
    /// </summary>
    public SoftJointLimit angularZLimit
    {
      get
      {
        SoftJointLimit softJointLimit;
        this.INTERNAL_get_angularZLimit(out softJointLimit);
        return softJointLimit;
      }
      set
      {
        this.INTERNAL_set_angularZLimit(ref value);
      }
    }

    /// <summary>
    ///   <para>The desired position that the joint should move into.</para>
    /// </summary>
    public Vector3 targetPosition
    {
      get
      {
        Vector3 vector3;
        this.INTERNAL_get_targetPosition(out vector3);
        return vector3;
      }
      set
      {
        this.INTERNAL_set_targetPosition(ref value);
      }
    }

    /// <summary>
    ///   <para>The desired velocity that the joint should move along.</para>
    /// </summary>
    public Vector3 targetVelocity
    {
      get
      {
        Vector3 vector3;
        this.INTERNAL_get_targetVelocity(out vector3);
        return vector3;
      }
      set
      {
        this.INTERNAL_set_targetVelocity(ref value);
      }
    }

    /// <summary>
    ///   <para>Definition of how the joint's movement will behave along its local X axis.</para>
    /// </summary>
    public JointDrive xDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_xDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_xDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>Definition of how the joint's movement will behave along its local Y axis.</para>
    /// </summary>
    public JointDrive yDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_yDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_yDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>Definition of how the joint's movement will behave along its local Z axis.</para>
    /// </summary>
    public JointDrive zDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_zDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_zDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>This is a Quaternion. It defines the desired rotation that the joint should rotate into.</para>
    /// </summary>
    public Quaternion targetRotation
    {
      get
      {
        Quaternion quaternion;
        this.INTERNAL_get_targetRotation(out quaternion);
        return quaternion;
      }
      set
      {
        this.INTERNAL_set_targetRotation(ref value);
      }
    }

    /// <summary>
    ///   <para>This is a Vector3. It defines the desired angular velocity that the joint should rotate into.</para>
    /// </summary>
    public Vector3 targetAngularVelocity
    {
      get
      {
        Vector3 vector3;
        this.INTERNAL_get_targetAngularVelocity(out vector3);
        return vector3;
      }
      set
      {
        this.INTERNAL_set_targetAngularVelocity(ref value);
      }
    }

    /// <summary>
    ///   <para>Control the object's rotation with either X &amp; YZ or Slerp Drive by itself.</para>
    /// </summary>
    public RotationDriveMode rotationDriveMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Definition of how the joint's rotation will behave around its local X axis. Only used if Rotation Drive Mode is Swing &amp; Twist.</para>
    /// </summary>
    public JointDrive angularXDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_angularXDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_angularXDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>Definition of how the joint's rotation will behave around its local Y and Z axes. Only used if Rotation Drive Mode is Swing &amp; Twist.</para>
    /// </summary>
    public JointDrive angularYZDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_angularYZDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_angularYZDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>Definition of how the joint's rotation will behave around all local axes. Only used if Rotation Drive Mode is Slerp Only.</para>
    /// </summary>
    public JointDrive slerpDrive
    {
      get
      {
        JointDrive jointDrive;
        this.INTERNAL_get_slerpDrive(out jointDrive);
        return jointDrive;
      }
      set
      {
        this.INTERNAL_set_slerpDrive(ref value);
      }
    }

    /// <summary>
    ///   <para>Brings violated constraints back into alignment even when the solver fails. Projection is not a physical process and does not preserve momentum or respect collision geometry. It is best avoided if practical, but can be useful in improving simulation quality where joint separation results in unacceptable artifacts.</para>
    /// </summary>
    public JointProjectionMode projectionMode { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>Set the linear tolerance threshold for projection.
    /// 
    /// If the joint separates by more than this distance along its locked degrees of freedom, the solver
    /// will move the bodies to close the distance.
    /// 
    /// Setting a very small tolerance may result in simulation jitter or other artifacts.
    /// 
    /// Sometimes it is not possible to project (for example when the joints form a cycle).</para>
    ///       </summary>
    public float projectionDistance { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///         <para>Set the angular tolerance threshold (in degrees) for projection.
    /// 
    /// If the joint deviates by more than this angle around its locked angular degrees of freedom,
    /// the solver will move the bodies to close the angle.
    /// 
    /// Setting a very small tolerance may result in simulation jitter or other artifacts.
    /// 
    /// Sometimes it is not possible to project (for example when the joints form a cycle).</para>
    ///       </summary>
    public float projectionAngle { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>If enabled, all Target values will be calculated in world space instead of the object's local space.</para>
    /// </summary>
    public bool configuredInWorldSpace { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>If enabled, the two connected rigidbodies will be swapped, as if the joint was attached to the other body.</para>
    /// </summary>
    public bool swapBodies { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_secondaryAxis(out Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_secondaryAxis(ref Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_linearLimitSpring(out SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_linearLimitSpring(ref SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularXLimitSpring(out SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularXLimitSpring(ref SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularYZLimitSpring(out SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularYZLimitSpring(ref SoftJointLimitSpring value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_linearLimit(out SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_linearLimit(ref SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_lowAngularXLimit(out SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_lowAngularXLimit(ref SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_highAngularXLimit(out SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_highAngularXLimit(ref SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularYLimit(out SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularYLimit(ref SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularZLimit(out SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularZLimit(ref SoftJointLimit value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_targetPosition(out Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_targetPosition(ref Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_targetVelocity(out Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_targetVelocity(ref Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_xDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_xDrive(ref JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_yDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_yDrive(ref JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_zDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_zDrive(ref JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_targetRotation(out Quaternion value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_targetRotation(ref Quaternion value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_targetAngularVelocity(out Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_targetAngularVelocity(ref Vector3 value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularXDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularXDrive(ref JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_angularYZDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_angularYZDrive(ref JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_get_slerpDrive(out JointDrive value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void INTERNAL_set_slerpDrive(ref JointDrive value);
  }
}
