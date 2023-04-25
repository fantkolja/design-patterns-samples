function fetchUser() {
  return fetch('https://dummyapi.io/data/v1/user', { headers: { 'app-id': '63ed1f61e68fff164f49f8b0' } })
    .then(response => response.json());
}

function pollUser() {
  let fetchCounter = 0;
  setInterval(async () => {
    const index = ++fetchCounter;
    console.log(`Fetching user... Request #${index}`);
    const user = await fetchUser();
    console.log(`Success... Request #${index}`, user);
  }, 1000);
}

const requestQueue = [];

function request(...args) {
  if (navigator.onLine) {
    return fetch(...args);
  } else {
    return new Promise((res) => {
      requestQueue.push(() => res(fetch(...args)));
    });
  }
}

function addOnlineEventListener() {
  window.addEventListener('online', () => {
    for (let i = 0, n = requestQueue.length; i < n; i++) {
      const fn = requestQueue.shift();
      fn();
    }
  });
}

function main() {
  addOnlineEventListener();
  pollUser();
}

main();
