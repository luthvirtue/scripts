bool isLoading;
	private IEnumerator shortLoading (float waitTime) {
		if (!isLoading) {
			isLoading = true;

			float timeLeft = Time.deltaTime;
			float rate = 1.0f / waitTime;
			float progress = 0.0f;

			while (progress <= 1.0f) {
				progress += rate * Time.deltaTime;
				timeLeft += Time.deltaTime;

				yield return null;
			}
			isLoading = false;

			//dosomething
		}
	}
