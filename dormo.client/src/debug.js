// Add this to your index.html or main entry file
console.log('Application is loading...');
window.addEventListener('error', function(e) {
    console.error('Global error caught:', e.error);
    document.body.innerHTML = `
        <div style="padding: 20px; font-family: Arial, sans-serif;">
            <h1>Something went wrong</h1>
            <p>Error: ${e.error?.message || 'Unknown error'}</p>
            <pre>${e.error?.stack || 'No stack trace available'}</pre>
        </div>
    `;
});

// Check if crucial dependencies are loaded
setTimeout(() => {
    console.log('React available:', !!window.React);
    console.log('Preact available:', !!window.preact);
}, 1000);
