import "./styles/app.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "react-toastify/dist/ReactToastify.css";
import { ToastContainer } from "react-toastify";
import Foot from "./layouts/Foot";
import { Nav } from "./layouts/Nav";
import ProtectedRoutes from "./utils/ProtectedRoutes";
import Highscores from "./routes/Highscores";
import Home from "./routes/Home";
import Login from "./routes/Login";
import PageNotFound from "./routes/PageNotFound";
import Profile from "./routes/Profile";
import Register from "./routes/Register";

function App() {
  return (
    <Router>
      <Nav />
      <ToastContainer />
      <Routes>
        <Route element={<Home />} path="/" exact />
        <Route element={<Login />} path="/login" />
        <Route element={<Register />} path="/register" />
        <Route element={<ProtectedRoutes />}>
          <Route element={<Highscores />} path="/highscores" />
          <Route element={<Profile />} path="/page" />
        </Route>
        <Route element={<PageNotFound />} path="*" />
      </Routes>
      <Foot />
    </Router>
  );
}

export default App;
