import React, { useState } from "react";
import Layout from './Layout';

const Counter = () => {
  const [count, setCount] = useState(0);

  return (
    <Layout>
      <h1>Counter</h1>

      <p>This is a simple example of a React component.</p>

      <p aria-live="polite">
        Current count: <strong>{count}</strong>
      </p>

      <button
        type="button"
        className="btn btn-primary btn-lg"
        onClick={() => {
          setCount(count + 1);
        }}
      >
        Increment
      </button>
    </Layout>
  );
};

export default Counter;
