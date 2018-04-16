private IEnumerator Loading (float waitTime) {
		if (!isLoading) {
			isLoading = true;
			loadCancel = false;
			imageRect.localPosition = startPos;

			float timeLeft = Time.deltaTime;
			float rate = 1.0f / waitTime;
			float progress = 0.0f;

			while (progress <= 1.0f) {
				if (!isTouched || !isPointing) {
					loadCancel = true;
					imageRect.localPosition = startPos;
					break;
				}

				imageRect.localPosition = Vector3.Lerp (startPos, endPos, progress);
				progress += rate * Time.deltaTime;
				timeLeft += Time.deltaTime;

				yield return null;
			}

			isLoading = false;
			isTouched = false;

			if (!loadCancel) {
				imageRect.localPosition = startPos;
				GoingBack ();
			}
		}
	}
