using UnityEngine;

namespace Controllers
{
	public class RotateController : MonoBehaviour
	{
		private float _totalRotationX = 0f;
		private float _totalRotationY = 0f;

		[SerializeField]
		private Vector3 _rotation = new Vector3(0f, 0f, 0f);

		[SerializeField]
		private float _rotateSpeed;

		public void SetStartRotation(Vector3 rotation)
		{
			_rotation = rotation;
			_totalRotationX = 0f;
			_totalRotationY = 0f;
		}

		public void ClockwiseRotateX()
		{
			if (_totalRotationX < 90f)
			{
				_totalRotationX += _rotateSpeed * Time.deltaTime;
				_rotation += new Vector3(_rotateSpeed, 0f, 0f) * Time.deltaTime;
				transform.rotation = Quaternion.Euler(_rotation);
			}
		}

		public void ClockwiseRotateY()
		{
			if (_totalRotationY < 90f)
			{
				_totalRotationY += _rotateSpeed * Time.deltaTime;
				_rotation += new Vector3(0f, _rotateSpeed, 0f) * Time.deltaTime;
				transform.rotation = Quaternion.Euler(_rotation);
			}
		}

		public void CounterClockwiseRotateX()
		{
			if (_totalRotationX > -90f)
			{
				_totalRotationX -= _rotateSpeed * Time.deltaTime;
				_rotation -= new Vector3(_rotateSpeed, 0f, 0f) * Time.deltaTime;
				transform.rotation = Quaternion.Euler(_rotation);
			}
		}

		public void CounterClockwiseRotateY()
		{
			if (_totalRotationY > -90f)
			{
				_totalRotationY -= _rotateSpeed * Time.deltaTime;
				_rotation -= new Vector3(0f, _rotateSpeed, 0f) * Time.deltaTime;
				transform.rotation = Quaternion.Euler(_rotation);
			}
		}
	}
}