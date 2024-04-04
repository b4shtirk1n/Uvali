import { BrowserRouter, Routes, Route } from "react-router-dom";
import React from "react";
import ReactDOM from "react-dom/client";
import App from "./pages/App";
import Analytics from "./Components/Analytics";
import "./styles/main.scss";

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App view={<Analytics />} />} />
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
