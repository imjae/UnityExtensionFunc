using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorExtension
{
    public static Vector3 InputDirection(this Vector3 direction)
    {
        Vector3 result = Vector3.zero;

        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        result = Vector3.forward * inputVertical + Vector3.right * inputHorizontal;

        return result.normalized;
    }

    public static Vector3 CalcJumpVelocity(this Vector3 velocity, float jumpHeight)
    {
        // ���ϴ� ���̱��� �����ϱ����� �ӷ��� ���ϴ� ����
        // v = ��Ʈ(h * -2 * g)
        Vector3 result = velocity;

        result.y = Mathf.Sqrt(jumpHeight * -2 * Physics.gravity.y);

        return result;
    }

    public static Vector3 CalcGravityVelocity(this Vector3 velocity)
    {
        // ���� �ӵ� �����ϴ� ����
        // 1/2 * �߷� * �ð�^2
        velocity.y = Physics.gravity.y * Time.deltaTime;

        return velocity;
    }
}