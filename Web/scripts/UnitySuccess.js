import { unityReady } from "./Click.js";

export let unityLoaded = false;

export function UnitySuccessFunc(unityInstance, progress) {
  if (!unityInstance.Module)
    return;

  if (progress == 1) {

    unityLoaded = true
    if (unityReady) {
      document.querySelector('.backgroundImg').remove();
      document.querySelector('.loading').remove();
      document.getElementById('unityContainer').style.display = "block";

    }
  }

}

